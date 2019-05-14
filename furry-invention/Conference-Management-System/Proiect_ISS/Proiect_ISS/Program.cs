using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Proiect_ISS.framework;
using Proiect_ISS.ui;
using Proiect_ISS.controller;
using Proiect_ISS.repository;

namespace Proiect_ISS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var repos = new Dictionary<int, Repository>(); 
            repos.Add(Controller.ACCOUNT_IDENTIFIER, new AccountRepository());
            repos.Add(Controller.ACCOUNT_SECTION_IDENTIFIER, new AccountSectionRepository());
            repos.Add(Controller.DEADLINE_IDENTIFIER, new DeadlineRepository());
            repos.Add(Controller.KEYWORD_IDENTIFIER, new KeywordRepository());
            repos.Add(Controller.PROPOSAL_IDENTIFIER, new ProposalRepository());
            repos.Add(Controller.REVIEW_IDENTIFIER, new ReviewRepository());
            repos.Add(Controller.SECTION_IDENTIFIER, new SectionRepository());
            repos.Add(Controller.TOPIC_IDENTIFIER, new TopicRepository());
            repos.Add(Controller.CONFERENCE_IDENTIFIER, new ConferenceRepository());
            var confRepo = new ConferenceRepository();
        
            var cont = new Controller(repos);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(cont));
        }
    }
}
