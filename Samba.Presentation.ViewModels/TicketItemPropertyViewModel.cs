﻿using Samba.Domain.Models.Tickets;
using Samba.Presentation.Common;

namespace Samba.Presentation.ViewModels
{
    public class TicketItemPropertyViewModel : ObservableObject
    {
        public OrderTagValue Model { get; set; }

        public TicketItemPropertyViewModel(OrderTagValue model)
        {
            Model = model;
        }

        public string DisplayString
        {
            get
            {
                if (Model.Quantity > 1)
                    return Model.Name + " x " + Model.Quantity.ToString("#");
                return Model.Name;
            }
        }

        public string PriceString
        {
            get
            {
                return Model.Price != 0 && !Model.CalculateWithParentPrice ? ((Model.Price + Model.TaxAmount) * Model.Quantity).ToString("#,#0.00") : "";
            }
        }
    }
}
