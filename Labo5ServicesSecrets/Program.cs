﻿using System.Security.Principal;

namespace Labo5ServicesSecrets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chapitre c1 = new Chapitre("Manage");
            Agent c1aa0 = new Agent(new Identite("Natalie", "Mills"), 26);
            Informateur c1aa0i0 = new Informateur(new Identite("Carter", "Howard"),18);
            c1aa0i0.AjouteDomaine("crime organisé");
            c1aa0i0.AjouteDomaine("espionnage technique");
            c1aa0.AjouteInformateur(c1aa0i0);
            Informateur c1aa0i1 = new Informateur(new Identite("Grace", "Potter"),33);
            c1aa0i1.AjouteDomaine("crime organisé");
            c1aa0i1.AjouteDomaine("espionnage technique");
            c1aa0i1.AjouteDomaine("vente d'armes");
            c1aa0.AjouteInformateur(c1aa0i1);
            Informateur c1aa0i2 = new Informateur(new Identite("Evelyn", "Cox"), 41);
            c1aa0i2.AjouteDomaine("crime organisé");
            c1aa0.AjouteInformateur(c1aa0i2);
            c1.AjouteAgent(c1aa0);
            Agent c1aa1 = new Agent(new Identite("Peyton", "Davidson"), 23);
            Informateur c1aa1i0 = new Informateur(new Identite("Aiden", "Hopkins"), 47);
            c1aa1i0.AjouteDomaine("mafia");
            c1aa1.AjouteInformateur(c1aa1i0);
            Informateur c1aa1i1 = new Informateur(new Identite("Kaylee", "Owens"), 26);
            c1aa1i1.AjouteDomaine("cambriolages");
            c1aa1i1.AjouteDomaine("vente d'armes");
            c1aa1.AjouteInformateur(c1aa1i1);
            c1.AjouteAgent(c1aa1);
            Agent c1aa2 = new Agent(new Identite("Landon", "Alexander"), 30);
            Informateur c1aa2i0 = new Informateur(new Identite("Isaac", "Parker"), 39);
            c1aa2i0.AjouteDomaine("espionnage technique");
            c1aa2i0.AjouteDomaine("mafia");
            c1aa2i0.AjouteDomaine("blanchiment d'argent");
            c1aa2.AjouteInformateur(c1aa2i0);
            Informateur c1aa2i1 = new Informateur(new Identite("Benjamin", "Duncan"), 22);
            c1aa2i1.AjouteDomaine("racket");
            c1aa2i1.AjouteDomaine("vente d'armes");
            c1aa2.AjouteInformateur(c1aa2i1);
            Informateur c1aa2i2 = new Informateur(new Identite("Mason", "Miss"), 34);
            c1aa2i2.AjouteDomaine("crime organisé");
            c1aa2i2.AjouteDomaine("drogue");
            c1aa2i2.AjouteDomaine("vente d'armes");
            c1aa2.AjouteInformateur(c1aa2i2);
            c1.AjouteAgent(c1aa2);
            Agent c1aa3 = new Agent(new Identite("Hannah", "Mary"), 47);
            Informateur c1aa3i0 = new Informateur(new Identite("Hannah", "Murphy"), 27);
            c1aa3i0.AjouteDomaine("drogue");
            c1aa3i0.AjouteDomaine("contrebande");
            c1aa3i0.AjouteDomaine("racket");
            c1aa3.AjouteInformateur(c1aa3i0);
            Informateur c1aa3i1 = new Informateur(new Identite("Brooklyn", "Page"),  25);
            c1aa3i1.AjouteDomaine("pègre");
            c1aa3i1.AjouteDomaine("pègre");
            c1aa3i1.AjouteDomaine("espionnage technique");
            c1aa3.AjouteInformateur(c1aa3i1);
            c1.AjouteAgent(c1aa3);
            Agent c1aa4 = new Agent(new Identite("Julian", "Hicks"), 38);
            Informateur c1aa4i0 = new Informateur(new Identite("Liam", "Murray"),  31);
            c1aa4i0.AjouteDomaine("mafia");
            c1aa4.AjouteInformateur(c1aa4i0);
            Informateur c1aa4i1 = new Informateur(new Identite("Christian","Thomas"), 42);
            c1aa4i1.AjouteDomaine("blanchiment d'argent");
            c1aa4i1.AjouteDomaine("mafia");
            c1aa4i1.AjouteDomaine("mafia");
            c1aa4.AjouteInformateur(c1aa4i1);
            c1.AjouteAgent(c1aa4);
            c1.AjouteSafehouse("Genêt", "Ruelle Marique, 125");
            c1.AjouteSafehouse("Astrance", "Chemin de Bateau, 234");
            c1.AjouteSafehouse("Buglose", "Rue Tabaral, 357");
            c1.AjouteSafehouse("Saponaire", "Chemin Masy, 128");
            c1.AjouteSafehouse("Digitale", "Chemin de la Taille Boha, 331");
            c1.AjouteSafehouse("Myosotis", "Rue Quirin, 142");
            c1.AjouteSafehouse("Potentille", "Place Sainte-Sévère, 277");
            Agent c1m0a0 = new Agent(new Identite("Isaiah", "Island"), 28);
            Informateur c1m0a0i0 = new Informateur(new Identite("Daniel", "Mc"), 18);
            c1m0a0i0.AjouteDomaine("drogue");
            c1m0a0i0.AjouteDomaine("pègre");
            c1m0a0.AjouteInformateur(c1m0a0i0);
            Informateur c1m0a0i1 = new Informateur(new Identite("Mason", "Jackson"),22);
            c1m0a0i1.AjouteDomaine("drogue");
            c1m0a0i1.AjouteDomaine("mafia");
            c1m0a0i1.AjouteDomaine("contrebande");
            c1m0a0.AjouteInformateur(c1m0a0i1);
            Informateur c1m0a0i2 = new Informateur(new Identite("Addison", "Phillips"), 39);
            c1m0a0i2.AjouteDomaine("espionnage technique");
            c1m0a0.AjouteInformateur(c1m0a0i2);
            c1.AjouteAgentMission("Chicorée", c1m0a0);
            Agent c1m0a1 = new Agent(new Identite("Lincoln", "Bros"), 42);
            Informateur c1m0a1i0 = new Informateur(new Identite("Elena", "Watts"),31);
            c1m0a1i0.AjouteDomaine("vente d'armes");
            c1m0a1i0.AjouteDomaine("cambriolages");
            c1m0a1i0.AjouteDomaine("cambriolages");
            c1m0a1.AjouteInformateur(c1m0a1i0);
            Informateur c1m0a1i1 = new Informateur(new Identite("Grace", "Bryan"),39);
            c1m0a1i1.AjouteDomaine("mafia");
            c1m0a1.AjouteInformateur(c1m0a1i1);
            c1.AjouteAgentMission("Chicorée", c1m0a1);
            Agent c1m1a0 = new Agent(new Identite("Daniel", "Williamson"), 34);
            Informateur c1m1a0i0 = new Informateur(new Identite("Noah", "Robert"),22);
            c1m1a0i0.AjouteDomaine("espionnage technique");
            c1m1a0.AjouteInformateur(c1m1a0i0);
            Informateur c1m1a0i1 = new Informateur(new Identite("William", "Clay"),45);
            c1m1a0i1.AjouteDomaine("drogue");
            c1m1a0i1.AjouteDomaine("cambriolages");
            c1m1a0i1.AjouteDomaine("drogue");
            c1m1a0.AjouteInformateur(c1m1a0i1);
            Informateur c1m1a0i2 = new Informateur(new Identite("Grayson", "Perry"),31);
            c1m1a0i2.AjouteDomaine("blanchiment d'argent");
            c1m1a0.AjouteInformateur(c1m1a0i2);
            c1.AjouteAgentMission("Gentiane", c1m1a0);
            Agent c1m1a1 = new Agent(new Identite("Nora", "Bruce"), 24);
            Informateur c1m1a1i0 = new Informateur(new Identite("Oliver", "Sherman"), 47);
            c1m1a1i0.AjouteDomaine("mafia");
            c1m1a1i0.AjouteDomaine("espionnage technique");
            c1m1a1i0.AjouteDomaine("vente d'armes");
            c1m1a1.AjouteInformateur(c1m1a1i0);
            Informateur c1m1a1i1 = new Informateur(new Identite("Liam", "Stanley"),33);
            c1m1a1i1.AjouteDomaine("mafia");
            c1m1a1.AjouteInformateur(c1m1a1i1);
            Informateur c1m1a1i2 = new Informateur(new Identite("Gabriel", "Watts"), 47);
            c1m1a1i2.AjouteDomaine("racket");
            c1m1a1i2.AjouteDomaine("espionnage technique");
            c1m1a1.AjouteInformateur(c1m1a1i2);
            Informateur c1m1a1i3 = new Informateur(new Identite("Evelyn", "Page"), 33);
            c1m1a1i3.AjouteDomaine("blanchiment d'argent");
            c1m1a1i3.AjouteDomaine("cambriolages");
            c1m1a1i3.AjouteDomaine("drogue");
            c1m1a1.AjouteInformateur(c1m1a1i3);
            Informateur c1m1a1i4 = new Informateur(new Identite("Owen", "Fleming"), 44);
            c1m1a1i4.AjouteDomaine("blanchiment d'argent");
            c1m1a1i4.AjouteDomaine("vente d'armes");
            c1m1a1.AjouteInformateur(c1m1a1i4);
            Informateur c1m1a1i5 = new Informateur(new Identite("Sophia", "Dixon"),  23);
            c1m1a1i5.AjouteDomaine("pègre");
            c1m1a1i5.AjouteDomaine("espionnage technique");
            c1m1a1.AjouteInformateur(c1m1a1i5);
            c1.AjouteAgentMission("Gentiane", c1m1a1);
            Agent c1m2a0 = new Agent(new Identite("Isaiah", "Crawford"), 34);
            Informateur c1m2a0i0 = new Informateur(new Identite("Dylan", "Lee"), 25);
            c1m2a0i0.AjouteDomaine("crime organisé");
            c1m2a0.AjouteInformateur(c1m2a0i0);
            Informateur c1m2a0i1 = new Informateur(new Identite("Abigail", "Morgan"), 20);
            c1m2a0i1.AjouteDomaine("drogue");
            c1m2a0.AjouteInformateur(c1m2a0i1);
            Informateur c1m2a0i2 = new Informateur(new Identite("Carter", "Kelly"), 41);
            c1m2a0i2.AjouteDomaine("contrebande");
            c1m2a0i2.AjouteDomaine("drogue");
            c1m2a0.AjouteInformateur(c1m2a0i2);
            Informateur c1m2a0i3 = new Informateur(new Identite("Andrew", "Bell"), 35);
            c1m2a0i3.AjouteDomaine("blanchiment d'argent");
            c1m2a0i3.AjouteDomaine("cambriolages");
            c1m2a0i3.AjouteDomaine("espionnage technique");
            c1m2a0.AjouteInformateur(c1m2a0i3);
            c1.AjouteAgentMission("Clématite", c1m2a0);
            c1.AjouteAgentMission("Clématite", c1m0a1);
            Agent c1m2a1 = new Agent(new Identite("Lincoln", "Graham"), 31);
            Informateur c1m2a1i0 = new Informateur(new Identite("Emily", "May"), 24);
            c1m2a1i0.AjouteDomaine("blanchiment d'argent");
            c1m2a1i0.AjouteDomaine("racket");
            c1m2a1.AjouteInformateur(c1m2a1i0);
            Informateur c1m2a1i1 = new Informateur(new Identite("Layla", "Washington"), 34);
            c1m2a1i1.AjouteDomaine("drogue");
            c1m2a1i1.AjouteDomaine("drogue");
            c1m2a1i1.AjouteDomaine("pègre");
            c1m2a1.AjouteInformateur(c1m2a1i1);
            Informateur c1m2a1i2 = new Informateur(new Identite("Mason", "Harrison"), 37);
            c1m2a1i2.AjouteDomaine("pègre");
            c1m2a1i2.AjouteDomaine("mafia");
            c1m2a1.AjouteInformateur(c1m2a1i2);
            Informateur c1m2a1i3 = new Informateur(new Identite("Dylan", "Blake"), 33);
            c1m2a1i3.AjouteDomaine("vente d'armes");
            c1m2a1i3.AjouteDomaine("blanchiment d'argent");
            c1m2a1i3.AjouteDomaine("cambriolages");
            c1m2a1.AjouteInformateur(c1m2a1i3);
            Informateur c1m2a1i4 = new Informateur(new Identite("Adeline", "Ann"), 35);
            c1m2a1i4.AjouteDomaine("espionnage technique");
            c1m2a1i4.AjouteDomaine("drogue");
            c1m2a1.AjouteInformateur(c1m2a1i4);
            Informateur c1m2a1i5 = new Informateur(new Identite("Michael", "Miles"),34);
            c1m2a1i5.AjouteDomaine("pègre");
            c1m2a1i5.AjouteDomaine("cambriolages");
            c1m2a1.AjouteInformateur(c1m2a1i5);
            c1.AjouteAgentMission("Clématite", c1m2a1);
            Agent c1m3a0 = new Agent(new Identite("Addison", "Reynolds"), 43);
            Informateur c1m3a0i0 = new Informateur(new Identite("Charlotte", "Hunt"), 40);
            c1m3a0i0.AjouteDomaine("drogue");
            c1m3a0.AjouteInformateur(c1m3a0i0);
            Informateur c1m3a0i1 = new Informateur(new Identite("Aiden", "Bryan"), 20);
            c1m3a0i1.AjouteDomaine("drogue");
            c1m3a0i1.AjouteDomaine("racket");
            c1m3a0i1.AjouteDomaine("mafia");
            c1m3a0.AjouteInformateur(c1m3a0i1);
            Informateur c1m3a0i2 = new Informateur(new Identite("Ella", "Fletcher"), 29);
            c1m3a0i2.AjouteDomaine("cambriolages");
            c1m3a0.AjouteInformateur(c1m3a0i2);
            Informateur c1m3a0i3 = new Informateur(new Identite("Hailey","Fletcher"), 31);
            c1m3a0i3.AjouteDomaine("pègre");
            c1m3a0i3.AjouteDomaine("blanchiment d'argent");
            c1m3a0.AjouteInformateur(c1m3a0i3);
            Informateur c1m3a0i4 = new Informateur(new Identite("Scarlett", "Lee"), 37);
            c1m3a0i4.AjouteDomaine("cambriolages");
            c1m3a0.AjouteInformateur(c1m3a0i4);
            Informateur c1m3a0i5 = new Informateur(new Identite("Emily", "Roberts"), 40);
            c1m3a0i5.AjouteDomaine("contrebande");
            c1m3a0i5.AjouteDomaine("blanchiment d'argent");
            c1m3a0.AjouteInformateur(c1m3a0i5);
            c1.AjouteAgentMission("Lys", c1m3a0);
            Agent c1m3a1 = new Agent(new Identite("Hailey", "Graham"), 20);
            Informateur c1m3a1i0 = new Informateur(new Identite("Jayce", "Nichols"), 30);
            c1m3a1i0.AjouteDomaine("espionnage technique");
            c1m3a1.AjouteInformateur(c1m3a1i0);
            Informateur c1m3a1i1 = new Informateur(new Identite("Oliver", "Wood"), 20);
            c1m3a1i1.AjouteDomaine("contrebande");
            c1m3a1i1.AjouteDomaine("crime organisé");
            c1m3a1.AjouteInformateur(c1m3a1i1);
            c1.AjouteAgentMission("Lys", c1m3a1);
            Agent c1m3a2 = new Agent(new Identite("Hailey", "Hill"), 39);
            Informateur c1m3a2i0 = new Informateur(new Identite("Mackenzie", "Kerr"), 33);
            c1m3a2i0.AjouteDomaine("crime organisé");
            c1m3a2.AjouteInformateur(c1m3a2i0);
            Informateur c1m3a2i1 = new Informateur(new Identite("Addison", "Knight"), 25);
            c1m3a2i1.AjouteDomaine("mafia");
            c1m3a2i1.AjouteDomaine("blanchiment d'argent");
            c1m3a2i1.AjouteDomaine("pègre");
            c1m3a2.AjouteInformateur(c1m3a2i1);
            Informateur c1m3a2i2 = new Informateur(new Identite("Nicholas", "Hunter"), 30);
            c1m3a2i2.AjouteDomaine("mafia");
            c1m3a2.AjouteInformateur(c1m3a2i2);
            Informateur c1m3a2i3 = new Informateur(new Identite("Nicholas", "Davis"), 28);
            c1m3a2i3.AjouteDomaine("blanchiment d'argent");
            c1m3a2.AjouteInformateur(c1m3a2i3);
            Informateur c1m3a2i4 = new Informateur(new Identite("Victoria", "Kerr"), 44);
            c1m3a2i4.AjouteDomaine("mafia");
            c1m3a2.AjouteInformateur(c1m3a2i4);
            Informateur c1m3a2i5 = new Informateur(new Identite("Landon", "Ellis"), 22);
            c1m3a2i5.AjouteDomaine("mafia");
            c1m3a2i5.AjouteDomaine("pègre");
            c1m3a2i5.AjouteDomaine("racket");
            c1m3a2.AjouteInformateur(c1m3a2i5);
            c1.AjouteAgentMission("Lys", c1m3a2);
            Agent c1m4a0 = new Agent(new Identite("Dylan", "Saunders"), 37);
            Informateur c1m4a0i0 = new Informateur(new Identite("Jayden", "Ellis"), 46);
            c1m4a0i0.AjouteDomaine("racket");
            c1m4a0i0.AjouteDomaine("blanchiment d'argent");
            c1m4a0.AjouteInformateur(c1m4a0i0);
            Informateur c1m4a0i1 = new Informateur(new Identite("Ethan", "Wheeler"), 45);
            c1m4a0i1.AjouteDomaine("drogue");
            c1m4a0i1.AjouteDomaine("espionnage technique");
            c1m4a0i1.AjouteDomaine("vente d'armes");
            c1m4a0.AjouteInformateur(c1m4a0i1);
            c1.AjouteAgentMission("Joubarde", c1m4a0);
            Agent c1m4a1 = new Agent(new Identite("Peyton", "Walker"), 24);
            Informateur c1m4a1i0 = new Informateur(new Identite("Mackenzie", "Coleman"), 40);
            c1m4a1i0.AjouteDomaine("cambriolages");
            c1m4a1i0.AjouteDomaine("vente d'armes");
            c1m4a1i0.AjouteDomaine("racket");
            c1m4a1.AjouteInformateur(c1m4a1i0);
            Informateur c1m4a1i1 = new Informateur(new Identite("Nathan", "Dunn"), 47);
            c1m4a1i1.AjouteDomaine("blanchiment d'argent");
            c1m4a1i1.AjouteDomaine("vente d'armes");
            c1m4a1.AjouteInformateur(c1m4a1i1);
            Informateur c1m4a1i2 = new Informateur(new Identite("Camilla", "Adams"), 38);
            c1m4a1i2.AjouteDomaine("mafia");
            c1m4a1.AjouteInformateur(c1m4a1i2);
            c1.AjouteAgentMission("Joubarde", c1m4a1);
            c1.AjouteAgentMission("Joubarde", c1m0a1);
            Agent c1m4a2 = new Agent(new Identite("Mason", "Brown"), 46);
            Informateur c1m4a2i0 = new Informateur(new Identite("Mackenzie", "Henry"), 24);
            c1m4a2i0.AjouteDomaine("vente d'armes");
            c1m4a2i0.AjouteDomaine("cambriolages");
            c1m4a2.AjouteInformateur(c1m4a2i0);
            Informateur c1m4a2i1 = new Informateur(new Identite("Lucas", "Barrett"), 30);
            c1m4a2i1.AjouteDomaine("espionnage technique");
            c1m4a2.AjouteInformateur(c1m4a2i1);
            Informateur c1m4a2i2 = new Informateur(new Identite("Caleb", "Sanders"), 27);
            c1m4a2i2.AjouteDomaine("cambriolages");
            c1m4a2.AjouteInformateur(c1m4a2i2);
            c1.AjouteAgentMission("Joubarde", c1m4a2);
            Console.WriteLine(c1);
        }
    }
}