using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabdushevDB_InterfaceAppProject
{
    public partial class HubForm : Form
    {
        public HubForm()
        {
            InitializeComponent();
        }

        private void TruckMarketButton_Click(object sender, EventArgs e)
        {
            Hide();
            DialogResult result = new TruckMarketForm().ShowDialog(this);
            Show();
            switch (result)
            {
                case DialogResult.OK:
                    GlobalsLabelText_Update();
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    MessageBox.Show("Ой");
                    break;
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Hide();
            DialogResult result = new OrderForm().ShowDialog(this);
            Show();
            switch (result)
            {
                case DialogResult.OK:
                    GlobalsLabelText_Update();
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    MessageBox.Show("Ой");
                    break;
            }
        }

        private void HubForm_Load(object sender, EventArgs e)
        {
            GlobalsLabelText_Update();
        }

        public void GlobalsLabelText_Update()
        {
            globalsLabel.Text = "Бюджет: " + Program.globals.budget.ToString() + " руб.; Текущая дата: " + Program.globals.cur_date.ToShortDateString() + ";";
        }

        private void GlobalsReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ReloadDatabaseGlobals();
            GlobalsLabelText_Update();
        }

        private void GlobalsChangeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = new ChangeGlobalDate().ShowDialog(this);
            switch (result)
            {
                case DialogResult.OK:
                    GlobalsLabelText_Update();
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    MessageBox.Show("Ой");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new InformationTableForm(
                "Популярные грузы",
                new InformationTableParametrs(
                    "SELECT  `cargo_types`.`id`, `cargo_types`.`name`, SUM(`orders`.`cargo_weight`) AS `sumw` FROM `orders` JOIN `cargo_types` ON `orders`.`cargo_type_id` = `cargo_types`.`id` WHERE @dateFilter GROUP BY `orders`.`cargo_type_id` ORDER BY `sumw` DESC",
                    true,
                    new (string, string)[] {
                        ("@dateFilter", "`orders`.`order_date`")
                    },
                    50,
                    ("id", "id"),
                    ("name", "Груз"),
                    ("owerall_weight", "Суммарный вес")
                    )
                ).Show(this);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new InformationTableForm(
                "Коэффициент бесполезного пробега грузовиков",
                new InformationTableParametrs(
                    "SELECT" +
                    "`trucks`.`id` AS `ID`," +
                    "`trucks`.`model`," +
                    "(" +
                    "SUM(`rEmpt`.`days`) / SUM(`rLoad`.`days`)" +
                    ") AS `koef`" +
                    "FROM" +
                    "`orders`" +
                    "JOIN `trucks` ON `orders`.`truck_id` = `trucks`.`id`" +
                    "JOIN `routes` AS `rEmpt`" +
                    "ON" +
                    "`orders`.`start_city_id` = `rEmpt`.`departure_city_id` AND `orders`.`load_city_id` = `rEmpt`.`destination_city_id`" +
                    "JOIN `routes` AS `rLoad`" +
                    "ON" +
                    "`orders`.`load_city_id` = `rLoad`.`departure_city_id` AND `orders`.`unload_city_id` = `rLoad`.`destination_city_id`" +
                    "WHERE" +
                    "(@dateFilter)" +
                    "GROUP BY" +
                    "`trucks`.`id`" +
                    "UNION ALL" +
                    "(" +
                    "SELECT" +
                    "('-') AS `ID`," +
                    "('Среднее')," +
                    "(" +
                    "SUM(`rEmpt`.`days`) / SUM(`rLoad`.`days`)" +
                    ") AS `koef`" +
                    "FROM" +
                    "`orders`" +
                    "JOIN `routes` AS `rEmpt`" +
                    "ON" +
                    "`orders`.`start_city_id` = `rEmpt`.`departure_city_id` AND `orders`.`load_city_id` = `rEmpt`.`destination_city_id`" +
                    "JOIN `routes` AS `rLoad`" +
                    "ON" +
                    "`orders`.`load_city_id` = `rLoad`.`departure_city_id` AND `orders`.`unload_city_id` = `rLoad`.`destination_city_id`" +
                    "WHERE" +
                    "(@dateFilter)" +
                    ")ORDER BY" +
                    "`ID` ASC",
                    true,
                    new (string, string)[] {
                        ("@dateFilter", "`orders`.`order_date`")
                    },
                    50,
                    ("id", "id"),
                    ("model", "Модель"),
                    ("koef", "Коэффициент бесполезного пробега")
                    )
                ).Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new InformationTableForm(
                "Коэффициент простоя грузовиков",
                new InformationTableParametrs(
                    "SELECT" +
                    "`trucks`.`id` AS `TID`," +
                    "`trucks`.`model`," +
                    "ROUND(" +
                    "`downValT`.`vSum` / `trucks`.`downtime_cost_pr_d`," +
                    "0" +
                    ") AS `prost`," +
                    "`actValT`.`act` AS `act`," +
                    "(" +
                    "IF(" +
                    "`actValT`.`act` = 0," +
                    "'бесконечность'," +
                    "ROUND(" +
                    "(" +
                    "`downValT`.`vSum` / `trucks`.`downtime_cost_pr_d`" +
                    ") / `actValT`.`act`," +
                    "4" +
                    ")" +
                    ")" +
                    ") AS `koef`" +
                    "FROM" +
                    "`trucks`" +
                    "JOIN(" +
                    "SELECT" +
                    "`orders`.`truck_id` AS `TID`," +
                    "SUM((`rEmpt`.`days`) + (`rLoad`.`days`)) AS `act`" +
                    "FROM" +
                    "`orders`" +
                    "JOIN `routes` AS `rEmpt`" +
                    "ON" +
                    "`orders`.`start_city_id` = `rEmpt`.`departure_city_id` AND `orders`.`load_city_id` = `rEmpt`.`destination_city_id`" +
                    "JOIN `routes` AS `rLoad`" +
                    "ON" +
                    "`orders`.`load_city_id` = `rLoad`.`departure_city_id` AND `orders`.`unload_city_id` = `rLoad`.`destination_city_id`" +
                    "WHERE" +
                    "(@dateFilterOrders)" +
                    "GROUP BY" +
                    "`TID`" +
                    ") AS `actValT`" +
                    "ON" +
                    "`trucks`.`id` = `actValT`.`TID`" +
                    "JOIN(" +
                    "SELECT" +
                    "`truck_money_trans`.`truck_id`," +
                    "SUM(`truck_money_trans`.`value`) AS `vSum`" +
                    "FROM" +
                    "`truck_money_trans`" +
                    "WHERE" +
                    "`truck_money_trans`.`truck_money_trans_type_id` = 1 AND (@dateFilterTMTrans)" +
                    "GROUP BY" +
                    "`truck_money_trans`.`truck_id`" +
                    ") AS `downValT`" +
                    "ON" +
                    "`trucks`.`id` = `downValT`.`truck_id`" +
                    "GROUP BY" +
                    "`trucks`.`id`" +
                    "UNION ALL" +
                    "(" +
                    "SELECT" +
                    "'*' AS `TID`," +
                    "'Всего'," +
                    "SUM(" +
                    "ROUND(" +
                    "`downValT`.`vSum` / `trucks`.`downtime_cost_pr_d`," +
                    "0" +
                    ")" +
                    ") AS `prost`," +
                    "SUM(`actValT`.`act`) AS `act`," +
                    "(" +
                    "IF(" +
                    "SUM(`actValT`.`act`) = 0," +
                    "'бесконечность'," +
                    "ROUND(" +
                    "SUM(" +
                    "ROUND(" +
                    "`downValT`.`vSum` / `trucks`.`downtime_cost_pr_d`," +
                    "0" +
                    ")" +
                    ") / SUM(`actValT`.`act`)," +
                    "4" +
                    ")" +
                    ")" +
                    ") AS `koef`" +
                    "FROM" +
                    "`trucks`" +
                    "JOIN(" +
                    "SELECT" +
                    "`orders`.`truck_id` AS `TID`," +
                    "SUM((`rEmpt`.`days`) + (`rLoad`.`days`)) AS `act`" +
                    "FROM" +
                    "`orders`" +
                    "JOIN `routes` AS `rEmpt`" +
                    "ON" +
                    "`orders`.`start_city_id` = `rEmpt`.`departure_city_id` AND `orders`.`load_city_id` = `rEmpt`.`destination_city_id`" +
                    "JOIN `routes` AS `rLoad`" +
                    "ON" +
                    "`orders`.`load_city_id` = `rLoad`.`departure_city_id` AND `orders`.`unload_city_id` = `rLoad`.`destination_city_id`" +
                    "WHERE" +
                    "(@dateFilterOrders)" +
                    "GROUP BY" +
                    "`TID`" +
                    ") AS `actValT`" +
                    "ON" +
                    "`trucks`.`id` = `actValT`.`TID`" +
                    "JOIN(" +
                    "SELECT" +
                    "`truck_money_trans`.`truck_id`," +
                    "SUM(`truck_money_trans`.`value`) AS `vSum`" +
                    "FROM" +
                    "`truck_money_trans`" +
                    "WHERE" +
                    "`truck_money_trans`.`truck_money_trans_type_id` = 1 AND (@dateFilterTMTrans)" +
                    "GROUP BY" +
                    "`truck_money_trans`.`truck_id`" +
                    ") AS `downValT`" +
                    "ON" +
                    "`trucks`.`id` = `downValT`.`truck_id`" +
                    ")" +
                    "ORDER BY" +
                    "`TID`",
                    true,
                    new (string,string)[] {
                        ("@dateFilterOrders", "`orders`.`order_date`"),
                        ("@dateFilterTMTrans", "`truck_money_trans`.`trans_date`"),
                    },
                    50,
                    ("id", "id"),
                    ("model", "Модель"),
                    ("prost", "Дней простоя"),
                    ("act", "Дней в пути"),
                    ("koef", "Коэффициент простоя")
                    )
                ).Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new InformationTableForm(
                "Активность городов по суммарному весу отправленного груза",
                new InformationTableParametrs(
                    "SELECT `cities`.`id`, `cities`.`city_name`, SUM(`orders`.`cargo_weight`) as `sumOtpr` FROM `orders` JOIN `cities` ON `orders`.`load_city_id` = `cities`.`id` WHERE @dateFilter GROUP BY `cities`.`id` ORDER BY `sumOtpr` DESC",
                    true,
                    new (string,string)[] {
                        ("@dateFilter", "`orders`.`order_date`")
                    },
                    50,
                    ("id", "id"),
                    ("city_name", "Город"),
                    ("sumOtpr", "Суммарный вес груза")
                    )
                ).Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new InformationTableForm(
                "Активность городов по суммарному весу принятого груза",
                new InformationTableParametrs(
                    "SELECT `cities`.`id`, `cities`.`city_name`, SUM(`orders`.`cargo_weight`) as `sumPrin` FROM `orders` JOIN `cities` ON `orders`.`unload_city_id` = `cities`.`id` WHERE @dateFilter GROUP BY `cities`.`id` ORDER BY `sumPrin` DESC",
                    true,
                    new (string,string)[] {
                        ("@dateFilter", "`orders`.`order_date`")
                    },
                    50,
                    ("id", "id"),
                    ("city_name", "Город"),
                    ("sumPrin", "Суммарный вес груза")
                    )
                ).Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new InformationTableForm(
                "Обзор грузовиков",
                new InformationTableParametrs(
                    "SELECT" +
                    "`trucks`.`id`," +
                    "`trucks`.`model`," +
                    "`cargo_forms`.`name`," +
                    "`trucks`.`lift_capacity`," +
                    "IFNULL(`cities`.`city_name`, '-') AS `cname`," +
                    "`truck_statuses`.`name`" +
                    "FROM" +
                    "`trucks`" +
                    "JOIN `cargo_forms` ON `trucks`.`cargo_form_id` = `cargo_forms`.`id`" +
                    "LEFT JOIN `cities` ON `trucks`.`city_id` = `cities`.`id`" +
                    "JOIN `truck_statuses` ON `trucks`.`truck_status_id` = `truck_statuses`.`id`" +
                    "ORDER BY" +
                    "`trucks`.`id` ASC",
                    false,
                    new (string, string)[0],
                    50,
                    ("id", "id"),
                    ("model", "Модель"),
                    ("cargo_forms", "Форма груза"),
                    ("lift_capacity", "Грузоподъемность"),
                    ("cname", "Город"),
                    ("truck_statuses", "Состояние")
                    )
                ).Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var ownedForm in this.OwnedForms)
            {
                ownedForm.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new InformationTableForm(
                "Обзор заказов",
                new InformationTableParametrs(
                    "SELECT" +
                    "`orders`.`id` AS `ID`," +
                    "`trucks`.`id` AS `TID`," +
                    "`trucks`.`model`," +
                    "`cargo_types`.`name`," +
                    "`orders`.`cargo_weight`," +
                    "IF(" +
                    "`orders`.`order_status_id` = 1," +
                    "`truck_statuses`.`name`," +
                    "`order_statuses`.`name`" +
                    ") AS `status`," +
                    "DATE_FORMAT(`orders`.`order_date`, '%d.%m.%y')," +
                    "`s_cities`.`city_name` AS `s_c_name`," +
                    "DATE_FORMAT(DATE_ADD(" +
                    "`orders`.`order_date`," +
                    "INTERVAL ROUND(`rEmpt`.`days`, 0) DAY" +
                    "), '%d.%m.%y') AS `load_date`," +
                    "`l_cities`.`city_name` AS `l_c_name`," +
                    "DATE_FORMAT(DATE_ADD(" +
                    "`orders`.`order_date`," +
                    "INTERVAL ROUND(`rEmpt`.`days` + `rLoad`.`days`, 0) DAY" +
                    "), '%d.%m.%y') AS `unload_date`," +
                    "`u_cities`.`city_name` AS `u_c_name`" +
                    "FROM" +
                    "`orders`" +
                    "JOIN `trucks` ON `orders`.`truck_id` = `trucks`.`id`" +
                    "JOIN `routes` AS `rEmpt`" +
                    "ON" +
                    "`orders`.`start_city_id` = `rEmpt`.`departure_city_id` AND `orders`.`load_city_id` = `rEmpt`.`destination_city_id`" +
                    "JOIN `routes` AS `rLoad`" +
                    "ON" +
                    "`orders`.`load_city_id` = `rLoad`.`departure_city_id` AND `orders`.`unload_city_id` = `rLoad`.`destination_city_id`" +
                    "JOIN `cities` AS `s_cities`" +
                    "ON" +
                    "`orders`.`start_city_id` = `s_cities`.`id`" +
                    "JOIN `cities` AS `l_cities`" +
                    "ON" +
                    "`orders`.`load_city_id` = `l_cities`.`id`" +
                    "JOIN `cities` AS `u_cities`" +
                    "ON" +
                    "`orders`.`unload_city_id` = `u_cities`.`id`" +
                    "JOIN `truck_statuses` ON `trucks`.`truck_status_id` = `truck_statuses`.`id`" +
                    "JOIN `order_statuses` ON `orders`.`order_status_id` = `order_statuses`.`id`" +
                    "JOIN `cargo_types` ON `orders`.`cargo_type_id` = `cargo_types`.`id`" +
                    "WHERE" +
                    "(@dateFilter)" +
                    "ORDER BY" +
                    "`ID` ASC",
                    true,
                    new (string,string)[] {
                        ("@dateFilter", "`orders`.`order_date`")
                    },
                    50,
                    ("ID", "id"),
                    ("TID", "id Грузовика"),
                    ("model", "Модель"),
                    ("cargo_type", "Груз"),
                    ("cargo_weight", "Вес груза"),
                    ("status", "Состояние"),
                    ("order_date", "Дата заказа"),
                    ("s_c_name", "Город выезда"),
                    ("load_date", "Дата загрузки"),
                    ("l_c_name", "Город загрузки"),
                    ("unload_date", "Дата разгрузки"),
                    ("u_c_name", "Город разгрузки")
                    )
                ).Show(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new ProfitAndLossTableForm(
                "Финансовый отчет",
                new InformationTableParametrs(
                    "SELECT" +
                    "`months`.`id`," +
                    "`months`.`name`," +
                    "(`ORD_SUMS`.`income` + `TRU_SUMS`.`income`) AS `income`," +
                    "(`ORD_SUMS`.`outcome` + `TRU_SUMS`.`outcome`) AS `outcome`," +
                    "(`ORD_SUMS`.`income` + `TRU_SUMS`.`income` - `ORD_SUMS`.`outcome` - `TRU_SUMS`.`outcome`) AS `dif`" +
                    "FROM" +
                    "`months`" +
                    "JOIN (SELECT" +
                    "`months`.`id` AS `mth`," +
                    "SUM(" +
                    "IF(" +
                    "`order_money_trans_types`.`in_out_come`," +
                    "`ord_money_trans`.`value`," +
                    "0" +
                    ")" +
                    ") AS `income`," +
                    "SUM(" +
                    "IF(" +
                    "`order_money_trans_types`.`in_out_come` = false," +
                    "`ord_money_trans`.`value`," +
                    "0" +
                    ")" +
                    ") AS `outcome`" +
                    "FROM `months`" +
                    "LEFT JOIN    (SELECT * FROM `order_money_trans` WHERE (@dateFilterOMTrans)) AS `ord_money_trans` ON `months`.`id` = MONTH(`ord_money_trans`.`trans_date`)" +
                    "LEFT JOIN `order_money_trans_types` ON `ord_money_trans`.`order_money_trans_type_id` = `order_money_trans_types`.`id`" +
                    "GROUP BY" +
                    "`mth`" +
                    ") AS `ORD_SUMS` ON `months`.`id` = `ORD_SUMS`.`mth`" +
                    "" +
                    "LEFT JOIN (SELECT" +
                    "`months`.`id` AS `mth`," +
                    "SUM(" +
                    "IF(" +
                    "`truck_money_trans_types`.`in_out_come`," +
                    "`tru_money_trans`.`value`," +
                    "0" +
                    ")" +
                    ") AS `income`," +
                    "SUM(" +
                    "IF(" +
                    "`truck_money_trans_types`.`in_out_come` = false," +
                    "`tru_money_trans`.`value`," +
                    "0" +
                    ")" +
                    ") AS `outcome`" +
                    "FROM" +
                    "`months`" +
                    "LEFT JOIN  (SELECT * FROM `truck_money_trans` WHERE (@dateFilterTMTrans)) AS `tru_money_trans`  ON `months`.`id` = MONTH(`tru_money_trans`.`trans_date`)" +
                    "LEFT JOIN `truck_money_trans_types` ON `tru_money_trans`.`truck_money_trans_type_id` = `truck_money_trans_types`.`id`" +
                    "GROUP BY" +
                    "`mth`" +
                    ") AS `TRU_SUMS` ON `months`.`id` = `TRU_SUMS`.`mth` WHERE @dateFilterQuarter",
                    true,
                    new (string,string)[] {
                        ("@dateFilterOMTrans", "`order_money_trans`.`trans_date`"),
                        ("@dateFilterTMTrans", "`truck_money_trans`.`trans_date`"),
                    },
                    50,
                    ("id", "id"),
                    ("months_name", "Месяц"),
                    ("income", "Доходы"),
                    ("outcome", "Расходы"),
                    ("dif", "Выручка")
                    )
                ).Show(this);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            DialogResult result = new TestForm().ShowDialog(this);
            Show();
            switch (result)
            {
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    GlobalsLabelText_Update();
                    break;
                default:
                    MessageBox.Show("Ой");
                    break;
            }
        }
    }

}
