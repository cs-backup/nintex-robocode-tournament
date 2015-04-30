using System.Drawing;
using Robocode;
using Robocode.Util;

namespace Nintex
{
    // Details - FILL IN!!
    // Name: Adarsh V K 
    // Email: ad4rsh@gmail.com
    // Phone Number: 01139933052
    public class Adarsh_Robot : JuniorRobot
    {
        int CONSTANT = 5; // loop for attack
        int rand = 1; //randomize movement

        public override void Run()
        {
            //Set the color of your robot
            var bodyColor = Color.Black;  // Body
            var gunColor = Color.Orange; // Gun          
            var radarColor = Color.Orange; // Radar
           
           
            this.SetColors(bodyColor.ToArgb(), gunColor.ToArgb(), radarColor.ToArgb());             

            // *** Your Code Below ***
            // How your robot moves //
            // Can do a circie, square, or some odd shape
            // Or maybe some kind of pattern?
            // Or be like the drunken master, just go in random directions
            // This is the main "loop" that will be run over and over again. Here, we are just moving in a circle.
            while (true)
            {   //random snake movement
                TurnLeft(10+rand);
                TurnRight(20+rand);
                TurnRight(30 + rand);
                TurnLeft(10 + rand);
                rand++; 
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
            TurnTo(scannedAngle);
            while (true) // fire 5 times
            {
                Ahead(10);
                Fire();
                CONSTANT--;
            }
            

            //Turn gun to face enemy? // 
            // Or ram the bot? //
            // Or run away? //                            

        }

        // Called with your robot is hit by a bullet
        public override void OnHitByBullet()
        {
            // Variables at your disposal (can use anywhere, but updated when event happens)
            var hitByBulletBearing = HitByBulletBearing; // The bearing of the bullet (in deg) 
                                                         // relative to your robots heading
            
            // *** Your Code Below ***
            rand = 1;
            while (rand < 5)
            {   //random snake movement
                TurnLeft(30 + rand);
                TurnRight(40 + rand);
                TurnRight(20 + rand);
                TurnLeft(40 + rand);
                rand++;
            }
            // Ouch! You got hit! //
            // Best to move... //

        }

        // Called with your robot hits a wall
        public override void OnHitWall()
        {
            // Variables at your disposal (can use anywhere, but updated when event happens)
            var bearing = HitWallBearing; // The bearing of the wall relative to your robot

            // *** Your Code Below ***
            
            
                Back(50);
                TurnTo(60);
            
            // Doh! You've hit a wall. //
            // Reverse, or move along the wall? hmm... //

        }
    }
}
