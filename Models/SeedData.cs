using _3312_CIDM_FINAL_PROJECT.Pages;
using Microsoft.EntityFrameworkCore;

namespace _3312_CIDM_FINAL_PROJECT
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlaybookDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PlaybookDbContext>>()))
            {
                if (context == null || context.Play == null)
                {
                    throw new ArgumentNullException("Null RazorPagesPlaybookDbContext");
                }

                // Look for any movies.
                if (context.Play.Any())
                {
                    return;   // DB has been seeded
                }

                context.Play.AddRange(
                   new Play
                    {
                        PlayID = 5,
                        Title = "Cobra",
                        Description = "A stealthy play where guards exchange the ball around the perimeter, waiting for the opportune moment to strike into the key.",
                        Teams = new List<Team>{
                            new Team {TeamID = 1},
                            new Team {TeamID = 2},
                        }
                           
                    },
                    new Play
                    {
                        PlayID = 6,
                        Title = "Condor",
                        Description = "Utilizes a high-flying forward to secure an advantageous position above the rim for a potential alley-oop.",
                        Teams = new List<Team>{
                            new Team {TeamID = 3},
                            new Team {TeamID = 4},
                        }
                    },
                    new Play
                    {
                        PlayID = 7,
                        Title = "Wolverine",
                        Description = "An aggressive rebound-focused play aimed to secure second-chance points through sheer tenacity and close-in positioning.",
                        Teams = new List<Team>{
                            new Team {TeamID = 5},
                            new Team {TeamID = 6},
                        }
                    },
                    new Play
                    {
                        PlayID = 8,
                        Title = "Barracuda",
                        Description = "A swift, slashing drive optimized for breaking through tight defenses and finishing with a strong layup or dunk.",
                        Teams = new List<Team>{
                            new Team {TeamID = 7},
                            new Team {TeamID = 8},
                        }
                    },
                    new Play
                    {
                        PlayID = 9,
                        Title = "Panther",
                        Description = "An adaptable play that switches from a passive stance to a quick attack, exploiting the defense's inattentiveness.",
                        Teams = new List<Team>{
                            new Team {TeamID = 9},
                            new Team {TeamID = 10},
                        }
                    },
                    new Play
                    {
                        PlayID = 10,
                        Title = "Mammoth",
                        Description = "A power-centered play that focuses on the center's ability to bulldoze through the lane and score under the rim.",
                        Teams = new List<Team>{
                            new Team {TeamID = 11},
                            new Team {TeamID = 12},
                        }
                    },
                    new Play
                    {
                        PlayID = 11,
                        Title = "Scorpion",
                        Description = "Involves a sudden backdoor cut from the wing, with the guard delivering a sharp, stinging pass to the cutter.",
                        Teams = new List<Team>{
                            new Team {TeamID = 13},
                            new Team {TeamID = 14},
                        }
                    },
                    new Play
                    {
                        PlayID = 12,
                        Title = "Falcon",
                        Description = "A high-speed play that uses quick passes and cuts to create an open jump shot for a guard or small forward.",
                        Teams = new List<Team>{
                            new Team {TeamID = 15},
                            new Team {TeamID = 16},
                        }
                    },
                    new Play
                    {
                        PlayID = 13,
                        Title = "Python",
                        Description = "A constricting defensive play followed by a slow, methodical offensive push, forcing the opponents into a mistake.",
                        Teams = new List<Team>{
                            new Team {TeamID = 17},
                            new Team {TeamID = 18},
                        }
                    },
                    new Play
                    {
                        PlayID = 14,
                        Title = "Shark",
                        Description = "This offensive play is designed to isolate the defense and create a one-on-one matchup for the team's best scorer.",
                        Teams = new List<Team>{
                            new Team {TeamID = 19},
                            new Team {TeamID = 20},
                        }
                    },
                    new Play
                    {
                        PlayID = 15,
                        Title = "Dragon",
                        Description = "A multifaceted play involving a series of fake moves and screens that end in a fiery finish at the basket.",
                        Teams = new List<Team>{
                            new Team {TeamID = 21},
                            new Team {TeamID = 22},
                        }
                    },
                    new Play
                    {
                        PlayID = 16,
                        Title = "Cougar",
                        Description = "A play that involves misdirection and a quick cut to the basket, using the forward as a decoy.",
                        Teams = new List<Team>{
                            new Team {TeamID = 23},
                            new Team {TeamID = 24},
                        }
                    },
                    new Play
                    {
                        PlayID = 17,
                        Title = "Leopard",
                        Description = "Employs speed and silence, with a wing player making a sudden drive for an agile finish at the hoop.",
                        Teams = new List<Team>{
                            new Team {TeamID = 25},
                            new Team {TeamID = 26},
                        }
                    },
                    new Play
                    {
                        PlayID = 18,
                        Title = "Ocelot",
                        Description = "A crafty perimeter play that creates space for a shooter through a web of screens and fake moves.",
                        Teams = new List<Team>{
                            new Team {TeamID = 27},
                            new Team {TeamID = 28},
                        }
                    },
                    new Play
                    {
                        PlayID = 19,
                        Title = "Gorilla",
                        Description = "A dominant post-up play, overpowering opponents in the paint for a close-range basket or foul.",
                        Teams = new List<Team>{
                            new Team {TeamID = 29},
                            new Team {TeamID = 30},
                        }
                    },
                    new Play
                    {
                        PlayID = 20,
                        Title = "Eagle",
                        Description = "A play from the top of the key designed to allow the team's guard to soar in for an elegant but effective finish.",
                        Teams = new List<Team>{
                            new Team {TeamID = 31},
                            new Team {TeamID = 32},
                        }
                    },
                    new Play
                    {
                        PlayID = 21,
                        Title = "Lynx",
                        Description = "A play focusing on agility, with quick transitions from defense to offense to catch the opposing team off-guard.",
                        Teams = new List<Team>{
                            new Team {TeamID = 33},
                            new Team {TeamID = 34},
                        }
                    },
                    new Play
                    {
                        PlayID = 22,
                        Title = "Tarantula",
                        Description = "A defensive strategy that ensnares opponents into making mistakes, quickly transitioning into a counterattack.",
                        Teams = new List<Team>{
                            new Team {TeamID = 35},
                            new Team {TeamID = 36},
                        }
                    },
                    new Play
                    {
                        PlayID = 23,
                        Title = "Jaguar",
                        Description = "A play that relies on quick reflexes and explosive power, creating scoring chances through athletic plays.",
                        Teams = new List<Team>{
                            new Team {TeamID = 37},
                            new Team {TeamID = 38},
                        }
                    },
                    new Play
                    {
                        PlayID = 24,
                        Title = "Hawk",
                        Description = "A vigilant play where the team circles the three-point line, probing for weaknesses before diving in for the score.",
                        Teams = new List<Team>{
                            new Team {TeamID = 39},
                            new Team {TeamID = 40},
                        }
                    },
                    new Play
                    {
                        PlayID = 25,
                        Title = "Serpent",
                        Description = "A deceptive play involving multiple feints and a quick strike near the baseline, aiming for an easy bucket or foul.",
                        Teams = new List<Team>{
                            new Team {TeamID = 41},
                            new Team {TeamID = 42},
                        }
                    },
                    new Play
                    {
                        PlayID = 26,
                        Title = "Titan",
                        Description = "A formidable strategy utilizing size and strength, focusing on down-low post moves to create high-percentage shots.",
                        Teams = new List<Team>{
                            new Team {TeamID = 43},
                            new Team {TeamID = 44},
                        }
                    },
                    new Play
                    {
                        PlayID = 1,
                        Title = "Mustang",
                        Description = "In this play, one player sets a screen (or pick) for another player with the ball. The player with the ball then dribbles towards the screen, using it as a shield to get past their defender. At the same time, the player who set the screen rolls towards the basket, creating an opportunity for a pass or a scoring opportunity. This play requires good timing and communication between the players involved, but it can be highly effective in creating scoring chances and forcing the defense to make split-second decisions.",
                        Teams = new List<Team>{
                            new Team {TeamID = 45},
                            new Team {TeamID = 46},
                        }
                    },
                    new Play
                    {
                        PlayID = 2,
                        Title = "Stallion",
                        Description = "This strategy involves a swift interchange between two players, allowing for a sudden break towards the hoop. Precision and alertness are key aspects for the players executing this maneuver.",
                        Teams = new List<Team>{
                            new Team {TeamID = 47},
                            new Team {TeamID = 48},
                        }
                    },
                    new Play
                    {
                        PlayID = 3,
                        Title = "Pegasus",
                        Description = "During this elaborate play, three team members collaborate to disorient the defense, using multiple screens to free up a shooter on the perimeter.", 
                        Teams = new List<Team>{
                            new Team {TeamID = 49},
                            new Team {TeamID = 50},
                        }
                    },
                    new Play
                    {
                        PlayID = 4,
                        Title = "Raptor",
                        Description = "A quick paced offensive action where a player cuts to the rim, catching the defense off guard for a quick score or foul opportunity.", 
                         Teams = new List<Team>{
                            new Team {TeamID = 51},
                            new Team {TeamID = 52},
                        }
                    },
                    new Play
                    {
                        PlayID = 24,
                        Title = "Griffin",
                        Description = "An aggressive defensive stance transitioning into a rapid offensive drive, aiming to outpace the opposing team's adjustments.",  
                        Teams = new List<Team>{
                            new Team {TeamID = 53},
                            new Team {TeamID = 54},
                        }
                    }

                );
                context.SaveChanges();
            }
        }
    }
}