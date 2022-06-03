using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThanksCardAPI.Models;

namespace ThanksCardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogonController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public LogonController(ApplicationContext context)
        {
            _context = context;

            if (_context.Users.Count() == 0)
            {
                // Usersテーブルが空なら初期データを作成する。
                _context.Users.Add(new User { Name = "admin", Password = "admin", IsAdmin = true });
                _context.Users.Add(new User { Name = "user", Password = "user", IsAdmin = false });
                _context.Users.Add(new User { Name = "比嘉哲平", Password = "Higa0001", IsAdmin = true });
                _context.Users.Add(new User { Name = "山田慎一", Password = "Yama0002", IsAdmin = true });
                _context.Users.Add(new User { Name = "金城まゆみ", Password = "Kinj0003", IsAdmin = true });
                _context.Users.Add(new User { Name = "高木弘樹", Password = "Taka0004", IsAdmin = true });
                _context.Users.Add(new User { Name = "小山育雄", Password = "Koya0005", IsAdmin = true });
                _context.Users.Add(new User { Name = "田原美由紀", Password = "Taha0006", IsAdmin = false });
                _context.Users.Add(new User { Name = "知念雅人", Password = "Chie0007", IsAdmin = false });
                _context.Users.Add(new User { Name = "山城亮介", Password = "Yama0008", IsAdmin = false });
                _context.Users.Add(new User { Name = "比嘉暉一郎", Password = "Higa0009", IsAdmin = false });
                _context.Users.Add(new User { Name = "安田千絵子", Password = "Yasu0010", IsAdmin = false });
                _context.Users.Add(new User { Name = "下地綾乃", Password = "Shim0011", IsAdmin = false });
                _context.Users.Add(new User { Name = "平良祐作", Password = "Tair0012", IsAdmin = false });
                _context.Users.Add(new User { Name = "前川博", Password = "Maek0013", IsAdmin = false });
                _context.Users.Add(new User { Name = "藤川裕香", Password = "Fuji0014", IsAdmin = false });
                _context.Users.Add(new User { Name = "新谷沢子", Password = "Shin0015", IsAdmin = false });
                _context.Users.Add(new User { Name = "鈴木一郎", Password = "Suzu0016", IsAdmin = false });
                _context.Users.Add(new User { Name = "田中五郎", Password = "Than0017", IsAdmin = false });
                _context.Users.Add(new User { Name = "城間真澄", Password = "Shir0018", IsAdmin = false });
                _context.Users.Add(new User { Name = "足立康史", Password = "Adac0019", IsAdmin = false });
                _context.Users.Add(new User { Name = "武藤純子", Password = "Muto0020", IsAdmin = false });
                _context.Users.Add(new User { Name = "西野大夢", Password = "Nisi0021", IsAdmin = false });
                _context.Users.Add(new User { Name = "山根秀次郎", Password = "Yama0022", IsAdmin = false });
                _context.Users.Add(new User { Name = "丹羽佑治", Password = "Tanb0023", IsAdmin = false });
                _context.Users.Add(new User { Name = "山田太郎", Password = "Yama0024", IsAdmin = false });
                _context.Users.Add(new User { Name = "大西秀宜", Password = "Ooni0025", IsAdmin = false });
                _context.Users.Add(new User { Name = "藤原裕香", Password = "Fuji0026", IsAdmin = false });
                _context.Users.Add(new User { Name = "安部沙織", Password = "Abee0027", IsAdmin = false });
                _context.Users.Add(new User { Name = "向井奈緒子", Password = "Muka0028", IsAdmin = false });
                _context.Users.Add(new User { Name = "大場秀宜", Password = "Ooba0029", IsAdmin = false });
                _context.Users.Add(new User { Name = "谷口雅宏", Password = "Tani0030", IsAdmin = false });
                _context.Users.Add(new User { Name = "松尾戴三", Password = "Mats0031", IsAdmin = false });
                _context.Users.Add(new User { Name = "山村昭彦", Password = "Yama0032", IsAdmin = false });
                _context.Users.Add(new User { Name = "村上晴彦", Password = "Mura0033", IsAdmin = false });
                _context.Users.Add(new User { Name = "小池陽子", Password = "Koik0034", IsAdmin = false });
                _context.Users.Add(new User { Name = "金子勝弘", Password = "Kane0035", IsAdmin = false });
                _context.Users.Add(new User { Name = "新谷護", Password = "Aray0036", IsAdmin = false });
                _context.Users.Add(new User { Name = "黒沢信也", Password = "Kuro0037", IsAdmin = false });
                _context.Users.Add(new User { Name = "川崎純太", Password = "Kawa0038", IsAdmin = false });
                _context.Users.Add(new User { Name = "金田彦好", Password = "Kane0039", IsAdmin = false });
                _context.Users.Add(new User { Name = "清水宏季", Password = "Shim0040", IsAdmin = false });
                _context.Users.Add(new User { Name = "秋田政年", Password = "Akit0041", IsAdmin = false });
                _context.Users.Add(new User { Name = "高井康次", Password = "Taka0042", IsAdmin = false });
                _context.Users.Add(new User { Name = "川島十志夫", Password = "Kawa0043", IsAdmin = false });
                _context.Users.Add(new User { Name = "藤村義子", Password = "Fuji0044", IsAdmin = false });
                _context.Users.Add(new User { Name = "柴田正次", Password = "Shib0045", IsAdmin = false });
                _context.Users.Add(new User { Name = "山田太郎", Password = "Yama0046", IsAdmin = false });
                _context.Users.Add(new User { Name = "大西秀宜", Password = "Ooni0047", IsAdmin = false });
                _context.Users.Add(new User { Name = "中西信好", Password = "Naka0048", IsAdmin = false });
                _context.Users.Add(new User { Name = "藤村義子", Password = "Fuji0049", IsAdmin = false });
                _context.Users.Add(new User { Name = "池田百合子", Password = "Iked0050", IsAdmin = false });
                _context.Users.Add(new User { Name = "水谷仁美", Password = "Mizu0051", IsAdmin = false });
                _context.Users.Add(new User { Name = "中村賢一", Password = "Naka0052", IsAdmin = false });
                _context.Users.Add(new User { Name = "高田麻美", Password = "Taka0053", IsAdmin = false });
                _context.Users.Add(new User { Name = "伊藤宏明", Password = "Itou0054", IsAdmin = false });
                _context.Users.Add(new User { Name = "吉田宏明", Password = "Yosh0055", IsAdmin = false });
                _context.Users.Add(new User { Name = "池田正明", Password = "Iked0056", IsAdmin = false });
                _context.Users.Add(new User { Name = "清水裕也", Password = "Shim0057", IsAdmin = false });
                _context.Users.Add(new User { Name = "早川和也", Password = "Haya0058", IsAdmin = false });
                _context.Users.Add(new User { Name = "田中尚孝", Password = "Tana0059", IsAdmin = false });
                _context.Users.Add(new User { Name = "土井徹", Password = "Doii0060", IsAdmin = false });
                _context.Users.Add(new User { Name = "遠藤幸夫", Password = "Endo0061", IsAdmin = false });
                _context.Users.Add(new User { Name = "下田雄一", Password = "Shim0062", IsAdmin = false });
                _context.Users.Add(new User { Name = "吉村亜希子", Password = "Yosh0063", IsAdmin = false });
                _context.Users.Add(new User { Name = "篠原真希", Password = "Shin0064", IsAdmin = false });
                _context.Users.Add(new User { Name = "青木亜耶", Password = "Aoki0065", IsAdmin = false });
                _context.Users.Add(new User { Name = "高橋真也", Password = "Taka0066", IsAdmin = false });
                _context.Users.Add(new User { Name = "藤澤由紀", Password = "Fuji0067", IsAdmin = false });
                _context.Users.Add(new User { Name = "遠藤真之", Password = "Endo0068", IsAdmin = false });
                _context.Users.Add(new User { Name = "川端武", Password = "Kawa0069", IsAdmin = false });
                _context.Users.Add(new User { Name = "友寄隆利", Password = "Tomo0070", IsAdmin = false });
                _context.SaveChanges();
            }
        }

        // POST api/logon
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            var authorizedUser = _context.Users.SingleOrDefault(x => x.Name == user.Name && x.Password == user.Password);
            if (authorizedUser == null)
            {
                return NotFound();
            }
            return authorizedUser;
        }
    }
}
