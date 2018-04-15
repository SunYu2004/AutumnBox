﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/4/15 0:22:01 (UTC +8:00)
** desc： ...
*************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutumnBox.OpenFramework.Script
{
    public class ScriptInfo
    {
        public virtual string Name { get; set; }
        public virtual string Auth { get; set; }
        public virtual int UpdateId { get; set; }
        public virtual bool Updatable { get; set; }
    }
}