using System;
using System.Drawing;
using Robocode;
using Robocode.Util;

namespace Nintex
{
    // Details - FILL IN!!
    // Name: Yuki Au Yong
    // Email: Yuki_auyong@hotmail.com   
    // Phone Number: 016-217-1354
    public class YukiAuyong_YayBot : JuniorRobot
    {        
        public override void Run()
        {
            //Set the color of your robot
            var bodyColor = Color.Pink;  // Body
            var gunColor = Color.DeepSkyBlue; // Gun          
            var radarColor = Color.DarkSeaGreen; // Radar
            this.SetColors(bodyColor.ToArgb(), gunColor.ToArgb(), radarColor.ToArgb());             

            // *** Your Code Below ***
            // How your robot moves //
            // Can do a circie, square, or some odd shape
            // Or maybe some kind of pattern?
            // Or be like the drunken master, just go in random directions
            // This is the main "loop" that will be run over and over again. Here, we are just moving in a circle.
            while (true)
            {
                //TurnLeft(20);
                //Ahead(100);

                var rand = new Random();
                var tempRandomNumber = rand.Next(10, 50);
                TurnAheadRight(tempRandomNumber,90);
                BearGunTo(0);
            
            }

        }

        // Called with another robot is detected
        public override void OnScannedRobot()
        {
            // Variables at your disposal (can use anywhere, but updated when event happens)
            var scannedAngle = ScannedAngle;      // Current angle to the scanned nearest other robot (in degrees)	                
            var scannedDistance = ScannedDistance;// The distance to the other robot (pixels)
            var scannedBearing = ScannedBearing;  // The bearing of the other robot in degrees (
                                                  // if robot is directly ahead its 0 deg)            
            var scannedEnergy = ScannedEnergy;    // The other robot's hit points
            var scannedVelocity = ScannedVelocity;// The velocity of the other robot

            
            // *** Your Code Below ***
            // What your bot does when it detects another bot //
            // Maybe target enemy and fire the gun? //
            //Turn gun to face enemy? // 
            // Or ram the bot? //
            // Or run away? //                            
            TurnGunTo(scannedAngle);
            var rand = new Random();
            var tempRandomNumber = rand.Next(-10, 10);
            var distance = (scannedDistance <= 30) ? 0 : scannedDistance - 30;
            
            if (Energy > 30)
            {
                Fire();
                TurnAheadRight(distance, tempRandomNumber);
            }
            else
            {
                TurnBackLeft(distance,90);                
            }
            
            
            
        }

        // Called with your robot is hit by a bullet
        public override void OnHitByBullet()
        {
            // Variables at your disposal (can use anywhere, but updated when event happens)
            var hitByBulletBearing = HitByBulletBearing; // The bearing of the bullet (in deg) 
                                                        // relative to your robots heading
            // *** Your Code Below ***
            var rand = new Random();
            var tempRandomNumber = rand.Next(-50, 50);
            TurnGunTo(HitByBulletBearing);
            Fire();
            TurnRight(HitByBulletBearing + tempRandomNumber);
            

            // Ouch! You got hit! //
            // Best to move... //

        }

        // Called with your robot hits a wall
        public override void OnHitWall()
        {
            // Variables at your disposal (can use anywhere, but updated when event happens)
            var bearing = HitWallBearing; // The bearing of the wall relative to your robot

            // *** Your Code Below ***
            Back(45);
            TurnAheadRight(10,45);
            // Doh! You've hit a wall. //
            // Reverse, or move along the wall? hmm... //
            BearGunTo(0);
            
        }
    }
}
