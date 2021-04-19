using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using LuckyTiketLib;
using LuckyTiketLib.Interface;

namespace LuckyTicketView
{
    class ConsoleController
    {
        #region =====----- PRIVATE DATA -----======

        private string _filePath = string.Empty;
        private int _startRange = -1;
        private int _finishRange = -1;
        
        private IView _view;
        private IAnalyzer _ticketAnalyzer;
        private ILuckyTicket _piterLuckyTiket;
        private ILuckyTicket _moskowLuckyTiket;
        private readonly LuckyTicketInitializer _ticket;
        private readonly Initializer _initialize;

        #endregion

        #region =======------ CTOR --------=====

        public ConsoleController(int startRange, int finishRange, string filePath = DefaultSettings.DEFAULT_FILE_PATH)
        {
            _filePath = filePath;
            _startRange = startRange;
            _finishRange = finishRange;
            _ticket = new LuckyTicketInitializer();
            _initialize = new Initializer();
            _view = _initialize.InitializeView();
        }

        #endregion

        public void Run()
        {
            string methodName = GetMethodNameInFile(_filePath);

            switch (methodName)
            {
                case "Moskow":
                    _moskowLuckyTiket = _ticket.InitializeMoskowTicket();
                    InitializeTicket(_moskowLuckyTiket);
                    break;
                case "Piter":
                    _piterLuckyTiket = _ticket.InitializePiterTicket();
                    InitializeTicket(_piterLuckyTiket);
                    break;

                default:
                    _view.PrintInstructions();
                    break;
            }
        }

        private void InitializeTicket(ILuckyTicket ticket)
        {
            _ticketAnalyzer = _initialize.InitializeAnalyzer(ticket);
            _moskowLuckyTiket.GetLuckyTicket(_startRange, _finishRange);
            _view.PrintResult(_ticketAnalyzer);
        }

        private string GetMethodNameInFile(string filePath)
        {
            string methodName = string.Empty;

            if (IsFileExist(filePath))
            {
                using (StreamReader read = new StreamReader(filePath))
                {
                    methodName = read.ReadLine();
                }
            }
            else
            {
                return DefaultSettings.INSTRUCTION;
            }

            return methodName;
        }

        private bool IsFileExist(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}
