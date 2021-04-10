using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabdushevDB_InterfaceAppProject
{
    static class DatabaseCommandStringsMamager
    {
        public static readonly string selectGlobals = "SELECT `globals`.* FROM `globals`";
        public static readonly string updateGlobalBudget = "UPDATE `globals` SET `globals`.`budget` = @budget";
        public static readonly string updateGlobalCurDate = "UPDATE `globals` SET `globals`.`cur_date` = @cur_date";
        public static readonly string updateGlobalLastUpdateDateToCurrent = "UPDATE `globals` SET `globals`.`last_update_date` = `globals`.`cur_date`";
        public static readonly string insertTruckOffer = "INSERT INTO `trucks` (`id`, `model`, `cargo_form_id`, `lift_capacity`, `price`, `downtime_cost_pr_d`, `transportation_cost_pr_d`, `empty_transp_cost_pr_d`, `city_id`, `truck_status_id`) VALUES(NULL, @model, @cargo_form_id, @lift_capacity, @price, @downtime_cost_pr_d, @transportation_cost_pr_d, @empty_transp_cost_pr_d, NULL, @truck_status_id)";
        public static readonly string selectCargoForms = "SELECT `cargo_forms`.* FROM `cargo_forms`";
        public static readonly string selectCities = "SELECT `cities`.* FROM `cities`";
        public static readonly string selectTrucksForSelling = "SELECT `trucks`.`id`, `trucks`.`model`, `cargo_forms`.`name` AS `cargo_form`, `trucks`.`lift_capacity`, `trucks`.`price`, `trucks`.`downtime_cost_pr_d`, `trucks`.`transportation_cost_pr_d`, `trucks`.`empty_transp_cost_pr_d`, `cities`.`city_name` FROM `trucks` LEFT JOIN `cargo_forms` ON `trucks`.`cargo_form_id` = `cargo_forms`.`id` LEFT JOIN `truck_statuses` ON `trucks`.`truck_status_id` = `truck_statuses`.`id` LEFT JOIN `cities` ON `trucks`.`city_id` = `cities`.`id` WHERE `truck_statuses`.`name` = \"Простой\" ORDER BY `id` ASC";
        public static readonly string selectTrucksForBuying = "SELECT `trucks`.`id`, `trucks`.`model`, `cargo_forms`.`name` AS `cargo_form`, `trucks`.`lift_capacity`, `trucks`.`price`, `trucks`.`downtime_cost_pr_d`, `trucks`.`transportation_cost_pr_d`, `trucks`.`empty_transp_cost_pr_d` FROM `trucks` LEFT JOIN `cargo_forms` ON `trucks`.`cargo_form_id` = `cargo_forms`.`id` LEFT JOIN `truck_statuses` ON `trucks`.`truck_status_id` = `truck_statuses`.`id` WHERE `truck_statuses`.`name` = \"Продан/Не куплен\" ORDER BY `id` ASC";
        public static readonly string updateTruckToBought = "UPDATE `trucks` SET `city_id` = @city_id, `truck_status_id` = '1' WHERE `trucks`.`id` = @truck_id";
        public static readonly string insertTruckBuyMoneyTrans = "INSERT INTO `truck_money_trans` (`id`, `value`, `trans_date`, `truck_id`, `truck_money_trans_type_id`) VALUES (NULL, @value, @trans_date,  @truck_id, '3')";
        public static readonly string updateTruckToSold = "UPDATE `trucks` SET `city_id` = NULL, `truck_status_id` = '4' WHERE `trucks`.`id` = @truck_id";
        public static readonly string insertTruckSellMoneyTrans = "INSERT INTO `truck_money_trans` (`id`, `value`, `trans_date`, `truck_id`, `truck_money_trans_type_id`) VALUES (NULL, @value, @trans_date,  @truck_id, '2')";

        public static readonly string insertOrder = "INSERT INTO `orders` (`id`, `truck_id`, `start_city_id`, `load_city_id`, `unload_city_id`, `cargo_type_id`, `cargo_weight`, `order_date`, `order_status_id`) VALUES (NULL, @truck_id, @start_city_id, @load_city_id, @unload_city_id, @cargo_type_id, @cargo_weight, @order_date, '1'); SELECT @@IDENTITY";
        public static readonly string insertOrderMoneyTrans = "INSERT INTO `order_money_trans` (`id`, `order_id`, `value`, `trans_date`, `order_money_trans_type_id`) VALUES (NULL, @order_id, @value, @trans_date, @order_money_trans_type_id)";
        public static readonly string updateTruckToExecutingOrder = "UPDATE `trucks` SET `city_id` = NULL, `truck_status_id` = @truck_status_id WHERE `trucks`.`id` = @truck_id";
    }
}
