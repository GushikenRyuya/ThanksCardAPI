using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThanksCardAPI.Models;
using System.Text;
using System.Net;

namespace ThanksCardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadThanksCardController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public DownloadThanksCardController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ThanksCard>> Downloadfile(long id)
        {
            var thankscard = await _context.ThanksCards.FindAsync(id);
            if (thankscard == null)
            {
                return NotFound();
            }
            return thankscard;

            //string str = "タイトル："+thankscard.Title+/*"\n送信者名:"+thankscard.To.Name +"\n受信者名:"+thankscard.From.Name+*/"\n本文:"+thankscard.Body;
            //Encoding encoding = Encoding.UTF8;
            //byte[] Bytes = encoding.GetBytes(str);
            //return File(Bytes, "%USERPROFILE%/Desktop", "test.txt");
        }
    }
}
