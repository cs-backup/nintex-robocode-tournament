using System.Drawing;
using Robocode;
using Robocode.Util;

namespace Nintex
{
    // Details - FILL IN!!
    // Name: Ahmad Imran bin Mohd Yusry
    // Email:arnrangothia@gmail.com
    // Phone Number:0192431849 
    public class Weed : JuniorRobot
    {        
        public override void Run()
        {
            //Set the color of your robot
            var bodyColor = Color.Black;  // Body
            var gunColor = Color.Orange; // Gun          
            var radarColor = Color.Red; // Radar
            this.SetColors(bodyColor.ToArgb(), gunColor.ToArgb(), radarColor.ToArgb());             

            // *** Your Code Below ***
            // How your robot moves //
            TurnAheadLeft(100,40);
            Back(30);
            TurnRight(90);
            Ahead(120);
            TurnAheadRight(100,40);
            Back(50);
            TurnBackLeft(110,30);
            Ahead(30);
            TurnBackLeft(110,30);
            Back(40);

            Ahead(50);
            Back(50);
            // Can do a circie, square, or some odd shape
            //Move backward



            // Or maybe some kind of pattern?
            // Or be like the drunken master, just go in random directions
            // This is the main "loop" that will be run over and over again. Here, we are just moving in a circle.
            while (true)
            {
                TurnLeft(20);
                Ahead(100);
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
            TurnGunTo(60);
            Fire(50);

            TurnGunRight(80);
            Fire(80);

            TurnTo(50);
            Fire(50);
            BearGunTo(0);
            TurnTo(180);
            Fire(180);
            TurnGunTo(270);
            Fire(270);

        }

        // Called with your robot is hit by a bullet
        public override void OnHitByBullet()
        {
            // Variables at your disposal (can use anywhere, but updated when event happens)
            var hitByBulletBearing = HitByBulletBearing; // The bearing of the bullet (in deg) 
                                                         // relative to your robots heading
            
            // *** Your Code Below ***

            // Ouch! You got hit! //
            // Best to move... //
            TurnRight(HitByBulletBearing+60);
            Ahead(60);
            Fire(50);


        }

        // Called with your robot hits a wall
        public override void OnHitWall()
        {
            // Variables at your disposal (can use anywhere, but updated when event happens)
            var bearing = HitWallBearing; // The bearing of the wall relative to your robot

            // *** Your Code Below ***

            // Doh! You've hit a wall. //
            // Reverse, or move along the wall? hmm... //
            Back(90);
            TurnBackRight(40, 40);
            Fire(70);


        }
    }
}
