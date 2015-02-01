using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fever_Web_API.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Event
    {//TODO add comments
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Link to the Promoters table - the people who actually organise/run the event
        /// </summary>
        public int PromoterId { get; set; }


        public EventHistory[] _eventHistory { get; set; }



    }
}