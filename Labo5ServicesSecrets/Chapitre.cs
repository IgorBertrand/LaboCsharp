using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5ServicesSecrets
{
    internal class Chapitre
    {
        public string NomVille { get; set; }
        private LinkedList<Agent> agents = new LinkedList<Agent>();
        private Dictionary<string,string> safehouses = new Dictionary<string, string>();
        private Dictionary<string,HashSet<Agent>> missions = new Dictionary<string, HashSet<Agent>>();
        public Chapitre(string nom) 
        { 
            this.NomVille= nom;
        }
        public void AjouteAgent(Agent agent)
        {
            if(!this.agents.Contains(agent)) this.agents.AddLast(agent);
        }
        public Agent DernierAgentEnDate
        {
            get
            {
                return agents.Last();
            }
            set
            {
                AjouteAgent(value);
            }
        }
        public void SupprimeAgent(Agent agent)
        {
            if(this.agents.Contains(agent)) this.agents.Remove(agent);
        }
        public HashSet<Agent> AgentsSelonID(Identite identite)
        {
            HashSet<Agent> result = new HashSet<Agent>();
            if(identite.Nom == null)
            {
                foreach(Agent agent in agents)
                {
                    if(agent.Id.Prenom == identite.Prenom) result.Add(agent);
                }
            }
            if(identite.Prenom == null)
            {
                foreach (Agent agent in agents)
                {
                    if (agent.Id.Nom == identite.Nom) result.Add(agent);
                }
            }
            if(identite.Nom!= null && identite.Prenom!= null)
            {
                foreach(Agent agent in agents)
                {
                    if (agent.Id.Nom == identite.Nom && agent.Id.Prenom == identite.Prenom) result.Add(agent);
                }
            }
            return result;
        }
        public void AfficheAgentsSelonID(Identite identite)
        {
            HashSet<Agent> result = new HashSet<Agent>();
            result = AgentsSelonID(identite);
            foreach(Agent agent in result)
            {
                Console.WriteLine(agent);
            }
        }
        public void AjouteSafehouse(string code, string adresse)
        {
            if(!this.safehouses.ContainsKey(code)) this.safehouses.Add(code, adresse);
        }
        public string AdresseSafehouse(string code)
        {
            string value;
            return this.safehouses.TryGetValue(code, out value) ? value : "Code inconnu";
        }
        public void AfficheCodesSafehouses()
        {
            foreach(var safehouse in safehouses)
            {
                Console.WriteLine(safehouse.Key);
            }
        }
        public void AjouteMission(string code)
        {
            if (!missions.ContainsKey(code)) missions.Add(code, new HashSet<Agent>());
        }
        public void AjouteAgentMission(string code, params Agent[] agent)
        {
            if (!missions.ContainsKey(code)) AjouteMission(code);
            foreach (Agent ag in agent)
            {
                missions[code].Add(ag);
            }
        }
        public void AfficheMissions(Agent agent)
        {
            foreach(var agents in missions)
            {
                foreach(Agent ag in agents.Value)
                {
                    if (ag == agent) Console.WriteLine(ag);
                }
            }
        }
        public override string ToString()
        {
            string message = "";
            message += "INFORMATIOSN SUR LE CHAPITRE DE " + NomVille + "\n\n";
            message += "AGENTS :\n\n";
            foreach(var agent in agents)
            {
                message+= agent.ToString() + "\n";
            }
            message += "SAFEHOUSES\n\n";
            foreach(var safehouse in safehouses)
            {
                message += safehouse.Key + " : " + safehouse.Value + "\n";
            }
            message+= "\n";
            foreach(var mission in missions)
            {
                message += "MISSION " + mission.Key + " (" + mission.Value.Count + " agents)\n\n";
                foreach(Agent agent in mission.Value)
                {
                    message+= agent.ToString() + "\n";
                }
            }
            return message;
        }
    }
}
