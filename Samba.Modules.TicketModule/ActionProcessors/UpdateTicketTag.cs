﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using Samba.Domain.Models.Tickets;
using Samba.Localization.Properties;
using Samba.Presentation.Services.Common;
using Samba.Services.Common;

namespace Samba.Modules.TicketModule.ActionProcessors
{
    [Export(typeof(IActionProcessor))]
    class UpdateTicketTag : ActionProcessor
    {
        public override void Process(ActionData actionData)
        {
            var ticket = actionData.GetDataValue<Ticket>("Ticket");
            if (ticket != null)
            {
                var tagName = actionData.GetAsString("TagName");
                var tagValue = actionData.GetAsString("TagValue");
                ticket.SetTagValue(tagName, tagValue);
            }
        }

        protected override object GetDefaultData()
        {
            return new { TagName = "", TagValue = "" };
        }

        protected override string GetActionName()
        {
            return Resources.UpdateTicketTag;
        }

        protected override string GetActionKey()
        {
            return ActionNames.UpdateTicketTag;
        }
    }
}
