using System;

namespace AnimalKingdom.Models
{
  public class Kingdom
  {
    public Kingdom(Node start)
    {
      Setup(start);
    }

    public void Setup(Node startNode)
    {
      Node verts = new Node("Vertebrates");
      Node inverts = new Node("Invertebrates");
      //   startNode.Children.Add(verts);
      startNode.AddNode(verts);
      startNode.AddNode(inverts);
      verts.Parent = startNode;
      inverts.Parent = startNode;


      Node warm = new Node("Warm-Blooded");

      Node mammal = new Node("Mammals");
      Node bird = new Node("Birds");


      Node cold = new Node("Cold-Booded");

      Node fish = new Node("Fish");
      Node reptile = new Node("Reptiles");
      Node amphib = new Node("Amphibians");



      Node legs = new Node("With Jointed Legs");

      Node threelegs = new Node("With 3 pairs of legs");
      Node morelegs = new Node("With more than 3 pairs of legs");


      Node nolegs = new Node("Without Legs");

      Node worm = new Node("Worm Like");
      Node notworm = new Node("Not-Worm Like");


      Node bear = new Node("Bear");
      Node tiger = new Node("Tiger");
      Node whale = new Node("Whale");

      Node ostrich = new Node("Ostrich");
      Node peacock = new Node("Peacock");
      Node eagle = new Node("Eagle");

      Node salmon = new Node("Salmon");
      Node goldfish = new Node("Goldfish");
      Node guppy = new Node("Guppy");

      Node turtle = new Node("Turtle");
      Node croc = new Node("Crocodile");
      Node snek = new Node("Snake");

      Node frog = new Node("Frog");
      Node toad = new Node("Toad");
      Node newt = new Node("Newt");

      Node ant = new Node("Ant");
      Node roach = new Node("Cockroach");
      Node bug = new Node("Ladybug");

      Node scorp = new Node("Scorpion");
      Node spider = new Node("Spider");
      Node milli = new Node("Millipede");

      Node earth = new Node("Earthworm");
      Node leech = new Node("Leech");

      Node fluke = new Node("Fluke Worm");
      Node tape = new Node("TapeWorm");


      verts.AddNode(warm);
      verts.AddNode(cold);
      warm.Parent = verts;
      warm.AddNode(mammal);
      warm.AddNode(bird);
      bird.Parent = warm;
      mammal.Parent = warm;
      mammal.AddNode(bear);
      mammal.AddNode(tiger);
      mammal.AddNode(whale);
      whale.Parent = mammal;
      bear.Parent = mammal;
      tiger.Parent = mammal;
      bird.AddNode(ostrich);
      bird.AddNode(peacock);
      bird.AddNode(eagle);
      ostrich.Parent = bird;
      peacock.Parent = bird;
      eagle.Parent = bird;

      cold.Parent = verts;
      cold.AddNode(fish);
      cold.AddNode(reptile);
      cold.AddNode(amphib);
      fish.Parent = cold;
      reptile.Parent = cold;
      amphib.Parent = cold;
      fish.AddNode(salmon);
      fish.AddNode(goldfish);
      fish.AddNode(guppy);
      salmon.Parent = fish;
      goldfish.Parent = fish;
      guppy.Parent = fish;
      reptile.AddNode(turtle);
      reptile.AddNode(croc);
      reptile.AddNode(snek);
      turtle.Parent = reptile;
      croc.Parent = reptile;
      snek.Parent = reptile;
      amphib.AddNode(frog);
      amphib.AddNode(toad);
      amphib.AddNode(newt);
      frog.Parent = amphib;
      toad.Parent = amphib;
      newt.Parent = amphib;

      inverts.AddNode(legs);
      inverts.AddNode(nolegs);
      legs.Parent = inverts;
      legs.AddNode(threelegs);
      legs.AddNode(morelegs);
      threelegs.Parent = legs;
      morelegs.Parent = legs;
      threelegs.AddNode(ant);
      threelegs.AddNode(roach);
      threelegs.AddNode(bug);
      ant.Parent = threelegs;
      roach.Parent = threelegs;
      bug.Parent = threelegs;
      morelegs.AddNode(scorp);
      morelegs.AddNode(spider);
      morelegs.AddNode(milli);
      scorp.Parent = morelegs;
      spider.Parent = morelegs;
      milli.Parent = morelegs;

      nolegs.Parent = inverts;
      nolegs.AddNode(worm);
      nolegs.AddNode(notworm);
      worm.Parent = nolegs;
      notworm.Parent = nolegs;
      worm.AddNode(earth);
      worm.AddNode(leech);
      earth.Parent = worm;
      leech.Parent = worm;
      notworm.AddNode(fluke);
      notworm.AddNode(tape);
      fluke.Parent = notworm;
      tape.Parent = notworm;

    }

    internal string viewKingdoms(Node currNode)
    {
      string template = $" - {currNode.Name} - \n";
      if (currNode.Children.Count == 0)
      {
        template += "No further animalia known";
      }
      for (int i = 0; i < currNode.Children.Count; i++)
      {
        Node n = currNode.Children[i];
        template += $"{i + 1}. {n.Name} \n";
      }
      return template;
    }
  }
}