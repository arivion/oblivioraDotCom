using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oblivioraDotCom.Model;

namespace oblivioraDotCom.Controllers
{
    [Route("api/engage")]
    [ApiController]
    public class EngageController : ControllerBase
    {
        [HttpPost]
        public IEnumerable<EngagePair> Post([FromForm]EngageRequest bodyData)
        {
            
            List<EngagePair> results = new List<EngagePair>();
            List<string> emblemOptions = EngageLists.getEmblems(bodyData.chapter, bodyData.dlc == "on");
            List<string> charOptions = EngageLists.getCharacters(bodyData.chapter, bodyData.fell == "on");

            Random random = new Random();

            if (!(bodyData.alear == null))
            {
                int emblemIndex = random.Next(0, emblemOptions.Count);
                string emblem = emblemOptions[emblemIndex];
                emblemOptions.RemoveAt(emblemIndex);

                charOptions.Remove("Alear");

                results.Add(new EngagePair
                {
                    Character = "Alear",
                    Emblem = emblem
                }) ;

                bodyData.units -= 1;
            }

            for (int i = 0; i < bodyData.units && charOptions.Count > 0; i++)
            {
                string emblem = "";

                if (emblemOptions.Count > 0) 
                {
                    int emblemIndex = random.Next(0, emblemOptions.Count);
                    emblem = emblemOptions[emblemIndex];
                    emblemOptions.RemoveAt(emblemIndex);
                }

                int charIndex = random.Next(0, charOptions.Count);
                string character = charOptions[charIndex];
                charOptions.RemoveAt(charIndex);

                results.Add(new EngagePair
                {
                    Character = character,
                    Emblem = emblem
                });
            }

            return results.ToArray();
        }
    }
}
