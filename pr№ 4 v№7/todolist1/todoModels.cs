using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr__4_v_7.todolist1
{
    internal class todoModel
    {
        public DateTime CreateDate { get; set; } = DateTime.Now;
        private bool _isdone;
        

        public bool IsDone
        {
            get { return _isdone; }
            set { _isdone = value; }
        }

        private string _text
        {
          get { return  _text; }
          set { _text = value; }

        }

        public string Text { get; internal set; }
    } 
    }

