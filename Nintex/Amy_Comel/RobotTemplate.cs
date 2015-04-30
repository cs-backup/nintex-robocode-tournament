using System.Drawing;
using System.Runtime.CompilerServices;
using Robocode;
using Robocode.Util;

namespace Nintex
{
    // Details - FILL IN!!
    // Name: AmizaAhmad
    // Email:Amiza.Ahmad@nintex.com
    // Phone Number: 0123503982
    public class Amy_Comel : JuniorRobot
    {
        public override void Run()
        {
            //Set the color of your robot
            var bodyColor = Color.Red;  // Body
            var gunColor = Color.Yellow; // Gun          
            var radarColor = Color.Green; // Radar
            this.SetColors(bodyColor.ToArgb(), gunColor.ToArgb(), radarColor.ToArgb());

            // *** Your Code Below ***
            // How your robot moves //
            // Can do a circie, square, or some odd shape
            // Or maybe some kind of pattern?
            // Or be like the drunken master, just go in random directions
            // This is the main "loop" that will be run over and over again. Here, we are just moving in a circle.
            while (true)
            {
                TurnLeft(60); TurnRight(60); TurnAheadRight(100, 50); TurnAheadLeft(100, 50);
                Ahead(50);
                TurnTo(80);
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
            this.TurnGunTo(scannedAngle);
            Fire(3);
            BearGunTo(90);
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
            TurnLeft(50); TurnRight(50);
        }

        // Called with your robot hits a wall
        public override void OnHitWall()
        {
            // Variables at your disposal (can use anywhere, but updated when event happens)
            var bearing = HitWallBearing; // The bearing of the wall relative to your robot

            // *** Your Code Below ***

            // Doh! You've hit a wall. //
            // Reverse, or move along the wall? hmm... //
            TurnBackRight(100, 50); Ahead(10);
        }
    }
}
