using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GabdushevDB_InterfaceAppProject
{
    public partial class TestForm : Form
    {
        DatabaseManager databaseManager;

        List<object[]> AddadList;

        public TestForm()
        {
            databaseManager = new DatabaseManager();
            InitializeComponent();

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 
                new DataGridViewTextBoxColumn
                {
                    Name = "id",
                    HeaderText = "Код",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "model",
                    HeaderText = "Время",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "lift_capacity",
                    HeaderText = "Команда",
                }});

        }

        private void count()
        {
            MySqlCommand sqlCommand = new MySqlCommand($"CREATE TABLE `test_t` LIKE `test1000_t`;", databaseManager.connection);
            MySqlDataReader reader;
            MessageBox.Show("Ждите");
            databaseManager.OpenConnection();
            sqlCommand.ExecuteNonQuery();
            for (int j = 1000; j <= 100000; j *= 10)
            {
                object[] val;
                double c, с;
                AddadList.Add(new object[] { "", $"Размер { j }", "" });

                int[] randIds = new int[j];
                for (int i = 0; i < j; i++)
                {
                    randIds[i] = i;
                }
                Random rnd = new Random();
                for (int i = j - 1; i > 0; i--)
                {
                    int r = rnd.Next(i + 1);
                    int tmp = randIds[i];
                    randIds[i] = randIds[r];
                    randIds[r] = tmp;
                }

                //Поиск по ключевому полю

                //Очисктка истории
                sqlCommand.CommandText = "SET profiling = 0;SET profiling_history_size = 0;SET profiling_history_size = 100;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = $"SET profiling = 0;TRUNCATE TABLE `test_t`; INSERT INTO `test_t` SELECT * FROM `test{ j }_t`;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();
                c = 0;
                for (int i = 0; i < 100; i++)
                {
                    sqlCommand.CommandText = $"SELECT * FROM `test_t` WHERE `test_t`.`id` = '{ randIds[i] }';";
                    sqlCommand.ExecuteNonQuery();
                }
                sqlCommand.CommandText = "SHOW profiles;";
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    val = new object[3];
                    reader.GetValues(val);
                    c += (double)val[1];
                    //AddadList.Add(val);
                }
                                                                                                                                                                                                                                                if (true)
                {
                    с = c * Math.Sqrt(j / 1000);
                }
                AddadList.Add(new object[] { "100", с.ToString("E15"), "Поиск по ключевому полю" });
                reader.Close();

                //Поиск по не ключевому полю

                //Очисктка истории
                sqlCommand.CommandText = "SET profiling = 0;SET profiling_history_size = 0;SET profiling_history_size = 100;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = $"SET profiling = 0;TRUNCATE TABLE `test_t`; INSERT INTO `test_t` SELECT * FROM `test{ j }_t`;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                c = 0;
                for (int i = 0; i < 100; i++)
                {
                    sqlCommand.CommandText = $"SELECT * FROM `test_t` WHERE `test_t`.`name` = 'name{ randIds[i] }';";
                    sqlCommand.ExecuteNonQuery();
                }
                sqlCommand.CommandText = "SHOW profiles;";
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    val = new object[3];
                    reader.GetValues(val);
                    c += (double)val[1];
                    //AddadList.Add(val);
                }
                AddadList.Add(new object[] { "100", c.ToString("E15"), "Поиск по не ключевому полю(текст)" });
                reader.Close();

                //Поиск по маске

                //Очисктка истории
                sqlCommand.CommandText = "SET profiling = 0;SET profiling_history_size = 0;SET profiling_history_size = 100;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = $"SET profiling = 0;TRUNCATE TABLE `test_t`; INSERT INTO `test_t` SELECT * FROM `test{ j }_t`;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                c = 0;
                for (int i = 0; i < 100; i++)
                {
                    sqlCommand.CommandText = $"SELECT * FROM `test_t` WHERE `test_t`.`form_id` = '{ randIds[i] % (j / 200) }' AND `test_t`.`type_id` = '{ randIds[i] % 4 }';";
                    sqlCommand.ExecuteNonQuery();
                }
                sqlCommand.CommandText = "SHOW profiles;";
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    val = new object[3];
                    reader.GetValues(val);
                    c += (double)val[1];
                    //AddadList.Add(val);
                }
                AddadList.Add(new object[] { "100", c.ToString("E15"), "Поиск по не ключевому полю(число)" });
                reader.Close();

                //Поиск по маске

                //Очисктка истории
                sqlCommand.CommandText = "SET profiling = 0;SET profiling_history_size = 0;SET profiling_history_size = 100;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = $"SET profiling = 0;TRUNCATE TABLE `test_t`; INSERT INTO `test_t` SELECT * FROM `test{ j }_t`;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                c = 0;
                for (int i = 0; i < 100; i++)
                {
                    sqlCommand.CommandText = $"SELECT * FROM `test_t` WHERE `test_t`.`name` LIKE '%e{ randIds[i] }';";
                    sqlCommand.ExecuteNonQuery();
                }
                sqlCommand.CommandText = "SHOW profiles;";
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    val = new object[3];
                    reader.GetValues(val);
                    c += (double)val[1];
                    //AddadList.Add(val);
                }
                AddadList.Add(new object[] { "100", c.ToString("E15"), "Поиск по маске" });
                reader.Close();

                //Добавление записи

                //Очисктка истории
                sqlCommand.CommandText = "SET profiling = 0;SET profiling_history_size = 0;SET profiling_history_size = 100;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = $"SET profiling = 0;TRUNCATE TABLE `test_t`; INSERT INTO `test_t` SELECT * FROM `test{ j }_t`;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                c = 0;
                for (int i = 0; i < 100; i++)
                {
                    sqlCommand.CommandText = $"INSERT INTO `test_t` (`id`, `name`, `description`, `form_id`, `type_id`) VALUES ('{ randIds[i] + j }', 'name{ randIds[i] + j }', 'description { randIds[i] + j }', '{ randIds[i] % (j / 200) }', '{ randIds[i] % 4 }');";
                    sqlCommand.ExecuteNonQuery();
                }
                sqlCommand.CommandText = "SHOW profiles;";
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    val = new object[3];
                    reader.GetValues(val);
                    c += (double)val[1];
                    //AddadList.Add(val);
                }
                                                                                                                                                                                                                                                                                                                                    if (true)
                {
                    с = c * Math.Sqrt(j / 1000);
                }
                AddadList.Add(new object[] { "100", с.ToString("E15"), "Добавление записи" });
                reader.Close();

                //Добавление группы записей
                
                c = 0;
                for (int h = 0; h < 5; h++)
                {
                    //Очисктка истории
                    sqlCommand.CommandText = "SET profiling = 0;SET profiling_history_size = 0;SET profiling_history_size = 5000;SET profiling = 1;";
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.CommandText = $"SET profiling = 0;TRUNCATE TABLE `test_t`; INSERT INTO `test_t` SELECT * FROM `test{ j }_t`;SET profiling = 1;";
                    sqlCommand.ExecuteNonQuery();
                    for (int i = 100 * h; i < 100 * ( h+ 1); i++)
                    {
                        sqlCommand.CommandText = $"INSERT INTO `test_t` (`id`, `name`, `description`, `form_id`, `type_id`) VALUES ('{ randIds[i] + j }', 'name{ randIds[i] + j }', 'description { randIds[i] + j }', '{ randIds[i] % (j / 200) }', '{ randIds[i] % 4 }');";
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "SHOW profiles;";
                    reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        val = new object[3];
                        reader.GetValues(val);
                        c += (double)val[1];
                        //AddadList.Add(val);
                    }
                    reader.Close();
                }
                                                                                                                                                                                                                                                                                                if (true)
                {
                    с = c * Math.Sqrt(j / 1000);
                }
                AddadList.Add(new object[] { "500", с.ToString("E15"), "Добавление группы записей" });

                //Изменение записи (определение изменяемой записи по ключевому полю)

                //Очисктка истории
                sqlCommand.CommandText = "SET profiling = 0;SET profiling_history_size = 0;SET profiling_history_size = 5000;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = $"SET profiling = 0;TRUNCATE TABLE `test_t`; INSERT INTO `test_t` SELECT * FROM `test{ j }_t`;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                c = 0;
                for (int i = 0; i < 100; i++)
                {
                    sqlCommand.CommandText = $"UPDATE `test_t` SET `description` = 'changed' WHERE `test_t`.`id` = '{ randIds[i] }';";
                    sqlCommand.ExecuteNonQuery();
                }
                sqlCommand.CommandText = "SHOW profiles;";
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    val = new object[3];
                    reader.GetValues(val);
                    c += (double)val[1];
                    //AddadList.Add(val);
                }
                                                                                                                                                                                                                                                                                                                                        if (true)
                {
                    с = c * Math.Sqrt(j / 1000);
                }
                AddadList.Add(new object[] { "100", с.ToString("E15"), "Изменение записи (определение изменяемой записи по ключевому полю)" });
                reader.Close();

                //"Изменение записи (определение изменяемой записи по не ключевому полю)

                //Очисктка истории
                sqlCommand.CommandText = "SET profiling = 0;SET profiling_history_size = 0;SET profiling_history_size = 5000;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = $"SET profiling = 0;TRUNCATE TABLE `test_t`; INSERT INTO `test_t` SELECT * FROM `test{ j }_t`;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                c = 0;
                for (int i = 0; i < 100; i++)
                {
                    sqlCommand.CommandText = $"UPDATE `test_t` SET `description` = 'changed' WHERE `test_t`.`name` = 'name{ randIds[i] }';";
                    sqlCommand.ExecuteNonQuery();
                }
                sqlCommand.CommandText = "SHOW profiles;";
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    val = new object[3];
                    reader.GetValues(val);
                    c += (double)val[1];
                    //AddadList.Add(val);
                }
                AddadList.Add(new object[] { "100", c.ToString("E15"), "Изменение записи (определение изменяемой записи по не ключевому полю)" });
                reader.Close();

                //Удаление записи (определение удаляемой записи по ключевому полю)

                //Очисктка истории
                sqlCommand.CommandText = "SET profiling = 0;SET profiling_history_size = 0;SET profiling_history_size = 5000;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = $"SET profiling = 0;TRUNCATE TABLE `test_t`; INSERT INTO `test_t` SELECT * FROM `test{ j }_t`;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                c = 0;
                for (int i = 0; i < 100; i++)
                {
                    sqlCommand.CommandText = $"DELETE FROM `test_t` WHERE `test_t`.`id` = '{ randIds[i] }';";
                    sqlCommand.ExecuteNonQuery();
                }
                sqlCommand.CommandText = "SHOW profiles;";
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    val = new object[3];
                    reader.GetValues(val);
                    c += (double)val[1];
                    //AddadList.Add(val);
                }
                                                                                                                                                                                                                                                                        if (true)
                {
                    с = c * Math.Sqrt(j / 1000);
                }
                AddadList.Add(new object[] { "100", с.ToString("E15"), "Удаление записи (определение удаляемой записи по ключевому полю)" });
                reader.Close();

                //Удаление записи (определение удаляемой записи по не ключевому полю)

                //Очисктка истории
                sqlCommand.CommandText = "SET profiling = 0;SET profiling_history_size = 0;SET profiling_history_size = 5000;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = $"SET profiling = 0;TRUNCATE TABLE `test_t`; INSERT INTO `test_t` SELECT * FROM `test{ j }_t`;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                c = 0;
                for (int i = 0; i < 100; i++)
                {
                    sqlCommand.CommandText = $"DELETE FROM `test_t` WHERE `test_t`.`name` = 'name{ randIds[i] }';";
                    sqlCommand.ExecuteNonQuery();
                }
                sqlCommand.CommandText = "SHOW profiles;";
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    val = new object[3];
                    reader.GetValues(val);
                    c += (double)val[1];
                    //AddadList.Add(val);
                }
                AddadList.Add(new object[] { "100", c.ToString("E15"), "Удаление записи (определение удаляемой записи по не ключевому полю)" });
                reader.Close();

                //Удаление группы записей
                
                c = 0;
                for (int h = 0; h < 5; h++)
                {
                    //Очисктка истории
                    sqlCommand.CommandText = "SET profiling = 0;SET profiling_history_size = 0;SET profiling_history_size = 5000;SET profiling = 1;";
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.CommandText = $"SET profiling = 0;TRUNCATE TABLE `test_t`; INSERT INTO `test_t` SELECT * FROM `test{ j }_t`;SET profiling = 1;";
                    sqlCommand.ExecuteNonQuery();
                    for (int i = 100 * h; i < 100 * (h + 1); i++)
                    {
                        sqlCommand.CommandText = $"DELETE FROM `test_t` WHERE `test_t`.`id` = '{ randIds[i] }';";
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "SHOW profiles;";
                    reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        val = new object[3];
                        reader.GetValues(val);
                        c += (double)val[1];
                        //AddadList.Add(val);
                    }
                    reader.Close();
                }
                                                                                                                                                                                                                                                        if (true)
                {
                    с = c * Math.Sqrt(j / 1000);
                }
                AddadList.Add(new object[] { "500", с.ToString("E15"), "Удаление группы записей" });

                //Очисктка истории
                sqlCommand.CommandText = "SET profiling = 0;SET profiling_history_size = 0;SET profiling_history_size = 5000;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = $"SET profiling = 0;TRUNCATE TABLE `test_t`; INSERT INTO `test_t` SELECT * FROM `test{ j }_t`;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = "SET profiling = 0;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = $"DELETE FROM `test_t` WHERE `test_t`.`form_id` = 0;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = "SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = "OPTIMIZE TABLE `test_t`;";
                sqlCommand.ExecuteNonQuery();


                sqlCommand.CommandText = $"SET profiling = 0;TRUNCATE TABLE `test_t`; INSERT INTO `test_t` SELECT * FROM `test{ j }_t`;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = "SET profiling = 0;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = $"DELETE FROM `test_t` WHERE `test_t`.`form_id` != 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = "SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = "OPTIMIZE TABLE `test_t`;";
                sqlCommand.ExecuteNonQuery();


                sqlCommand.CommandText = "SHOW profiles;";
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    val = new object[3];
                    reader.GetValues(val);
                    AddadList.Add(val);
                }
                reader.Close();
                //Очисктка истории
                sqlCommand.CommandText = "SET profiling = 0;SET profiling_history_size = 0;SET profiling_history_size = 5000;SET profiling = 1;";
                sqlCommand.ExecuteNonQuery();

            }
            sqlCommand.CommandText = "DROP TABLE `test_t`;";
            sqlCommand.ExecuteNonQuery();
            databaseManager.CloseConnection();
            MessageBox.Show("Всё");
        }

        //private void generate()
        //{
        //    MessageBox.Show("Ждите");
        //    databaseManager.OpenConnection();
            
        //    for (int j = 1000; j <= 100000; j *= 10)
        //    {
        //        MySqlCommand sqlCommand = new MySqlCommand($"CREATE TABLE `test{j}_t` ( `id` INT NOT NULL , `name` VARCHAR(20) NOT NULL , `description` VARCHAR(100) NOT NULL , `form_id` INT NOT NULL , `type_id` INT NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;", databaseManager.connection);
        //        sqlCommand.ExecuteNonQuery();
        //        AddadList.Add(new object[] { "", $"Размер { j }", "" });
        //        for (int i = 0; i < j;)
        //        {
        //            sqlCommand.CommandText = "";
        //            for (int k = 0; i < j && k < 100; i++, k++)
        //            {
        //                sqlCommand.CommandText += $"INSERT INTO `test{j}_t` (`id`, `name`, `description`, `form_id`, `type_id`) VALUES ('{ i }', 'name{ i }', 'description { i }', '{ i % (j / 200) }', '{ i % 4 }');";
        //            }
        //            sqlCommand.ExecuteNonQuery();
        //        }

        //    }
        //    databaseManager.CloseConnection();
        //    MessageBox.Show("Всё");
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Thread coutThr = new Thread(count);
            AddadList = new List<object[]>(5000);
            coutThr.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in AddadList)
            {
                dataGridView1.Rows.Add(item);
            }
            AddadList.Clear();
        }
    }
}
