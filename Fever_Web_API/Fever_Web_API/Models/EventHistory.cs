using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fever_Web_API.Models
{
    /// <summary>
    /// Describes the change made to an Event
    /// </summary>
    public class EventHistory
    {

        //TODO add comments
        public int Id { get; set; }

        public EventChangeType EventChange { get; set; }




    }
}