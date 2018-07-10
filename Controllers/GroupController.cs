using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace RapperAPI.Controllers {
    public class GroupController : Controller {
        List<Group> allGroups {get; set;}
        List<Artist> allArtists {get; set;}
        public GroupController() {
            allGroups = JsonToFile<Group>.ReadJson();
            allArtists = JsonToFile<Artist>.ReadJson();
        }
        // 1.) Create a route /groups that returns all groups as JSON

        // 2.) Create a route /groups/name/{name} that returns all groups that match the provided name

        // 3.) Create a route /groups/id/{id} that returns all groups with the provided Id value
        
        // 4.) (Optional) Add an extra boolean parameter to the group routes called displayArtists that will include members for all Group JSON responses
    }
}