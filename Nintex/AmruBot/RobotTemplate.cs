using System.Drawing;
using Robocode;
using Robocode.Util;

namespace Nintex
{
    // Details - FILL IN!!
    // Name: muhammad amru al-as bin mohd royahan
    // Email: amrualas@engineer.com
    // Phone Number: 013 6442671
    public class AmruBot : JuniorRobot
    {        
        public override void Run()
        {
            //Set the color of your robot
            var bodyColor = Color.Black;  // Body
            var gunColor = Color.Blue; // Gun          
            var radarColor = Color.FloralWhite; // Radar
            this.SetColors(bodyColor.ToArgb(), gunColor.ToArgb(), radarColor.ToArgb());             

            // *** Your Code Below ***
            // How your robot moves //
            // Can do a circie, square, or some odd shape
            // Or maybe some kind of pattern?
            // Or be like the drunken master, just go in random directions
            // This is the main "loop" that will be run over and over again. Here, we are just moving in a circle.
            while (true)
            {
                TurnLeft(20);
                Ahead(100);
                TurnAheadLeft(100,90);
                Ahead(50);
                TurnBackRight(60,60);
                Ahead(50);
                TurnGunTo(50);
                Fire();
                TurnBackRight(50,20);
                Ahead(100);
                TurnAheadRight(50,90);
                Ahead(50);
                TurnBackLeft(100,60);
                Ahead(50);
                TurnGunTo(60);
                Fire();

            }

        }

        // Called with another robot is detected
        public override void OnScannedRobot()
        {
            // Variables at your disposal (can use anywhere, but updated when event happens)
            var scannedAngle = (ScannedAngle+180);      // Current angle to the scanned nearest other robot (in degrees)	                
            var scannedDistance = ScannedDistance;// The distance to the other robot (pixels)
            var scannedBearing = ScannedBearing;  // The bearing of the other robot in degrees (
                                                  // if robot is directly ahead its 0 deg)            
            var scannedEnergy = ScannedEnergy;    // The other robot's hit points
            var scannedVelocity = ScannedVelocity+10;// The velocity of the other robot

            
            // *** Your Code Below ***
            // What your bot does when it detects another bot //
            // Maybe target enemy and fire the gun? //
            //Turn gun to face enemy? // 
            // Or ram the bot? //
            // Or run away? //                            

        }

        // Called with your robot is hit by a bullet
        public override void OnHitByBullet()
        {
            // Variables at your disposal (can use anywhere, but updated when event happens)
            var hitByBulletBearing = (HitByBulletBearing+90); // The bearing of the bullet (in deg) 
                                                         // relative to your robots heading
            
            // *** Your Code Below ***

            // Ouch! You got hit! //
            // Best to move... //

        }

        // Called with your robot hits a wall
        public override void OnHitWall()
        {
            // Variables at your disposal (can use anywhere, but updated when event happens)
            var bearing = (HitWallBearing+60); // The bearing of the wall relative to your robot

            // *** Your Code Below ***

            // Doh! You've hit a wall. //
            // Reverse, or move along the wall? hmm... //

        }
    }
}
