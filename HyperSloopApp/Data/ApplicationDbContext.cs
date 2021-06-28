using HyperSloopApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyperSloopApp.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SlideEvent> SlideEvents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<SensorEvent> SensorEvents { get; set; }

        //public DbSet<ScanEvent> ScanEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<SlideEvent>(eb =>
                {
                    eb.HasNoKey();
                    eb.ToView("slideevents");
                });
         
//            var sql = @"CREATE 
//    ALGORITHM = UNDEFINED 
//    DEFINER = `root`@`localhost` 
//    SQL SECURITY DEFINER
//VIEW `hypersloop`.`slideevent` AS
//    SELECT 
//        CONCAT(`userstart`.`EventId`,
//                '_',
//                `slidestart`.`EventId`,
//                '_',
//                `slideend`.`EventId`) AS `SlideEventid`,
//        `userstart`.`UserId` AS `UserId`,
//        `userstart`.`SlideId` AS `SlideId`,
//        `userstart`.`DateTime` AS `ScanTime`,
//        `slidestart`.`DateTime` AS `StartTime`,
//        `slideend`.`DateTime` AS `EndTime`,
//        (TIMESTAMPDIFF(MICROSECOND,
//            `userstart`.`DateTime`,
//            `slidestart`.`DateTime`) / 1000000) AS `Scan Duration`,
//        (TIMESTAMPDIFF(MICROSECOND,
//            `slidestart`.`DateTime`,
//            `slideend`.`DateTime`) / 1000000) AS `Slide Duration`
//    FROM
//        ((`hypersloop`.`events` `userstart`
//        JOIN `hypersloop`.`events` `slidestart` ON (((`userstart`.`SlideId` = `slidestart`.`SlideId`)
//            AND (`slidestart`.`DateTime` > `userstart`.`DateTime`)
//            AND (TIMESTAMPDIFF(SECOND, `userstart`.`DateTime`, `slidestart`.`DateTime`) < 10)
//            AND (`slidestart`.`EventType` = 2)
//            AND (`userstart`.`EventType` = 1))))
//        JOIN `hypersloop`.`events` `slideend` ON (((`slidestart`.`SlideId` = `slideend`.`SlideId`)
//            AND (`slideend`.`DateTime` > `slidestart`.`DateTime`)
//            AND (TIMESTAMPDIFF(SECOND, `slidestart`.`DateTime`, `slideend`.`DateTime`) < 10)
//            AND (`slideend`.`EventType` = 3))))
//";                
                


            //            CREATE
            //    ALGORITHM = UNDEFINED
            //    DEFINER = `root`@`localhost` 
            //    SQL SECURITY DEFINER
            //VIEW `hypersloop`.`slideevent` AS
            //    SELECT
            //        CONCAT(`userstart`.`EventId`,
            //                '_',
            //                `slidestart`.`EventId`,
            //                '_',
            //                `slideend`.`EventId`) AS `SlideEventid`,
            //        `userstart`.`UserId` AS `UserId`,
            //        `userstart`.`SlideId` AS `SlideId`,
            //        `userstart`.`DateTime` AS `ScanTime`,
            //        `slidestart`.`DateTime` AS `StartTime`,
            //        `slideend`.`DateTime` AS `EndTime`,
            //        (TIMESTAMPDIFF(MICROSECOND,
            //            `userstart`.`DateTime`,
            //            `slidestart`.`DateTime`) / 1000000) AS `Scan Duration`,
            //        (TIMESTAMPDIFF(MICROSECOND,
            //            `slidestart`.`DateTime`,
            //            `slideend`.`DateTime`) / 1000000) AS `Slide Duration`
            //    FROM
            //        ((`hypersloop`.`events` `userstart`
            //        JOIN `hypersloop`.`events` `slidestart` ON(((`userstart`.`SlideId` = `slidestart`.`SlideId`)
            //            AND(`slidestart`.`DateTime` > `userstart`.`DateTime`)
            //            AND(TIMESTAMPDIFF(SECOND, `userstart`.`DateTime`, `slidestart`.`DateTime`) < 10)
            //            AND(`slidestart`.`EventType` = 2)
            //            AND(`userstart`.`EventType` = 1))))
            //        JOIN `hypersloop`.`events` `slideend` ON(((`slidestart`.`SlideId` = `slideend`.`SlideId`)
            //            AND(`slideend`.`DateTime` > `slidestart`.`DateTime`)
            //            AND(TIMESTAMPDIFF(SECOND, `slidestart`.`DateTime`, `slideend`.`DateTime`) < 10)
            //            AND(`slideend`.`EventType` = 3))))
        }
    }
}
