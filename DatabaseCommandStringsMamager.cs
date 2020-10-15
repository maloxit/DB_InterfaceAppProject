using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabdushevDB_InterfaceAppProject
{
    static class DatabaseCommandStringsMamager
    {
        public static readonly string addTruckOfferString = "INSERT INTO `trucks` (`id`, `model`, `cargo_form_id`, `lift_capacity`, `price`, `downtime_cost_pr_d`, `transportation_cost_pr_d`, `empty_transp_cost_pr_d`, `route_id`, `truck_status_id`) VALUES(NULL, @model, @cargo_form_id, @lift_capacity, @price, @downtime_cost_pr_d, @transportation_cost_pr_d, @empty_transp_cost_pr_d, NULL, @truck_status_id)";
        public static readonly string selectCargoForms = "SELECT `cargo_forms`.* FROM `cargo_forms`";
        public static readonly string selectCities = "SELECT `cities`.* FROM `cities`";
        public static readonly string selectTrucksForSelling = "SELECT `trucks`.`id`, `trucks`.`model`, `cargo_forms`.`name` AS `cargo_form`, `trucks`.`lift_capacity`, `trucks`.`price`, `trucks`.`downtime_cost_pr_d`, `trucks`.`transportation_cost_pr_d`, `trucks`.`empty_transp_cost_pr_d`, `cit`.`city_name` FROM `trucks` LEFT JOIN `cargo_forms` ON `trucks`.`cargo_form_id` = `cargo_forms`.`id` LEFT JOIN `truck_statuses` ON `trucks`.`truck_status_id` = `truck_statuses`.`id` LEFT JOIN( SELECT `cities`.`city_name`, `routes`.`id` FROM `routes` LEFT JOIN `cities` ON `routes`.`departure_city_id` = `cities`.`id` WHERE `routes`.`departure_city_id` = `routes`.`destination_city_id` ) `cit` ON `trucks`.`route_id` = `cit`.`id` WHERE `truck_statuses`.`name` = \"Простой\" ORDER BY `id` ASC";
        public static readonly string selectTrucksForBuying = "SELECT `trucks`.`id`, `trucks`.`model`, `cargo_forms`.`name` AS `cargo_form`, `trucks`.`lift_capacity`, `trucks`.`price`, `trucks`.`downtime_cost_pr_d`, `trucks`.`transportation_cost_pr_d`, `trucks`.`empty_transp_cost_pr_d` FROM `trucks` LEFT JOIN `cargo_forms` ON `trucks`.`cargo_form_id` = `cargo_forms`.`id` LEFT JOIN `truck_statuses` ON `trucks`.`truck_status_id` = `truck_statuses`.`id` WHERE `truck_statuses`.`name` = \"Продан/Не куплен\" ORDER BY `id` ASC";
        public static readonly string updateTruckToBought;
        public static readonly string insertTruckBuyMoneyTrans;
        public static readonly string updateTruckToSold;
        public static readonly string insertTruckSellMoneyTrans;
    }
}
