using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpp.Webhook.Domain.Entities;

public class WebhookPayload
{
    public Guid Id { get; set; } = Guid.NewGuid();
    //public DateTime DateReceived { get; set; } = DateTime.UtcNow.Date;
    public string DateReceived { get; set; } 
    public DateTime DateTimeReceived { get; set; } = DateTime.UtcNow;
    public string Payload { get; set; }
    public string Source { get; set; }
}
