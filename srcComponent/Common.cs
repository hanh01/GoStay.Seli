using System.Globalization;
using GoStay.Peter;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GoStay.Seli.srcComponent;

public static class Common
{
    static Common()
    {
    }

    public static DateTime JavaTimeStampToDateTime( long javaTimeStamp )
    {
        // Java timestamp is milliseconds past epoch
        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        dateTime = dateTime.AddMilliseconds( javaTimeStamp ).ToLocalTime();
        return dateTime;
    }
    public static String DatetimeToString(DateTime input)
    {
        var result = "tháng " + input.Month + " năm " + input.Year;
        return result;
    }
    public static int DatetimeToStringByDay(DateTime input)
    {
        var day = input.Day;
        return day;
    }

    static string StringJSon = "{\"list\":[{\"name\":\"scenic_views\",\"label\":\"Cảnhđẹp\",\"items\":[{\"name\":\"beachview\",\"label\":\"Hướngrabiển\"},{\"name\":\"bayview\",\"label\":\"Hướngravịnh\"},{\"name\":\"gardenview\",\"label\":\"Hướngravườn\"},{\"name\":\"oceanview\",\"label\":\"Hướngrađạidương\"},{\"name\":\"resortview\",\"label\":\"Hướngrakhunghỉdưỡng\"},{\"name\":\"moutaintview\",\"label\":\"Hướngranúi\"}]},{\"name\":\"entertainment\",\"label\":\"Giảitrí\",\"items\":[{\"name\":\"tv\",\"label\":\"Tivi\",\"icon\":\"n(8547)\"},{\"name\":\"netflix\",\"label\":\"Netflix\",\"icon\":\"n(9579)\"},{\"name\":\"boardgame\",\"label\":\"Boardgame\"},{\"name\":\"piano\",\"label\":\"Piano\"},{\"name\":\"tablepingpong\",\"label\":\"Bànpingpong\"},{\"name\":\"pooltable\",\"label\":\"Bànbi-a\"},{\"name\":\"soundsystem\",\"label\":\"Dànloa\"}]},{\"name\":\"bathroom\",\"label\":\"Nhàtắm\",\"items\":[{\"name\":\"toothbrush\",\"label\":\"Bànchải,kemđánhrăng\",\"icon\":\"n(5605)\"},{\"name\":\"conditional\",\"label\":\"Dầuxả\"},{\"name\":\"hottub\",\"label\":\"Bồntắm\",\"icon\":\"n(8646)\"},{\"name\":\"hotwater\",\"label\":\"Nướcnóng\"},{\"name\":\"hairdryer\",\"label\":\"Máysấytóc\",\"icon\":\"n(2060)\"},{\"name\":\"iron\",\"label\":\"Bànlà\"},{\"name\":\"towel\",\"label\":\"Khăntắm\"},{\"name\":\"shampoo\",\"label\":\"Dầugội\"},{\"name\":\"showergel\",\"label\":\"Sữatắm\"},{\"name\":\"hotwaterheater\",\"label\":\"Bìnhnónglạnh\"}]},{\"name\":\"heating_and_cooling\",\"label\":\"Làmấmvàlàmmát\",\"items\":[{\"name\":\"airconditioning\",\"label\":\"Điềuhòa\",\"icon\":\"n(4663)\"},{\"name\":\"heating\",\"label\":\"Lòsưởi\"},{\"name\":\"fan\",\"label\":\"Quạt\"}]},{\"name\":\"home_safety\",\"label\":\"Nhàantoàn\",\"items\":[{\"name\":\"smokealarm\",\"label\":\"Chuôngbáocháy\"},{\"name\":\"carbonmonoxidealarm\",\"label\":\"ChuôngbáoCO2\"},{\"name\":\"firstaidkit\",\"label\":\"Dụngcụsơcứu\"},{\"name\":\"fireextinguisher\",\"label\":\"Bìnhdậplửa\"}]},{\"name\":\"internet_and_office\",\"label\":\"Mạngvàphònglàmviệc\",\"items\":[{\"name\":\"wifi\",\"label\":\"Wifi\",\"icon\":\"n(5043)\"},{\"name\":\"workdesk\",\"label\":\"Bànlàmviệc\"},{\"name\":\"privatelivingroom\",\"label\":\"Phòngkháchriêng\"}]},{\"name\":\"parking_and_facilities\",\"label\":\"Bãiđậuxevàcơsởvậtchất\",\"items\":[{\"name\":\"parkingwithfee\",\"label\":\"Chỗđểxecóphí\",\"icon\":\"n(4385)\"},{\"name\":\"pool\",\"label\":\"Bểbơi\",\"icon\":\"n(9392)\"},{\"name\":\"sauna\",\"label\":\"Phòngtắmhơi\"},{\"name\":\"gym\",\"label\":\"Phònggym\"},{\"name\":\"elevator\",\"label\":\"Thangmáy\",\"icon\":\"n(9601)\"},{\"name\":\"freeparkingcar\",\"label\":\"Miễnphíđỗxeôtô\",\"icon\":\"n(5628)\"},{\"name\":\"freeparkingstreet\",\"label\":\"Miễnphíđỗxetrênđường\",\"icon\":\"n(1562)\"},{\"name\":\"freeparkingmoto\",\"label\":\"Miễnphíđỗxemáy\",\"icon\":\"n(1244)\"}]},{\"name\":\"bedroom_and_laundry\",\"label\":\"Phòngngủvàgiặtủi\",\"items\":[{\"name\":\"safe\",\"label\":\"Kétsắt\"},{\"name\":\"clothingstorage\",\"label\":\"Tủquầnáo\"},{\"name\":\"dryingrackforclothing\",\"label\":\"Giáphơiquầnáo\"},{\"name\":\"hangers\",\"label\":\"Móctreoquầnáo\"},{\"name\":\"extrapillowsandblankets\",\"label\":\"Gốivàchăndựphòng\"},{\"name\":\"washer\",\"label\":\"Máygiặt\",\"icon\":\"n(2078)\"},{\"name\":\"dryer\",\"label\":\"Máysấy\",\"icon\":\"n(7816)\"},{\"name\":\"fullbodymirror\",\"label\":\"Gươngtoànthân\",\"icon\":\"n(2844)\"},{\"name\":\"laundrydetergent\",\"label\":\"Nướcgiặt\"}]},{\"name\":\"services\",\"label\":\"Dịchvụ\",\"items\":[{\"name\":\"breakfast\",\"label\":\"Bữasáng\",\"icon\":\"n(373)\"},{\"name\":\"mineral_water\",\"label\":\"Nướclọcmiễnphí\"},{\"name\":\"photographyroom\",\"label\":\"Chụpảnh\",\"icon\":\"n(3211)\"},{\"name\":\"party\",\"label\":\"Tổchứctiệc\",\"icon\":\"n(9830)\"},{\"name\":\"bbqgrill\",\"label\":\"LònướngBBQ\"},{\"name\":\"suckball\",\"label\":\"Hútbóng\",\"icon\":\"n(5787)\"},{\"name\":\"bikes\",\"label\":\"Xeđạp\"},{\"name\":\"kayak\",\"label\":\"Thuyềnkayak\"},{\"name\":\"smokingallowed\",\"label\":\"Chophéphútthuốc\"},{\"name\":\"allowplayingloudmusic\",\"label\":\"Chophépmởnhạcto\"},{\"name\":\"petsallowed\",\"label\":\"Chophépchómèo\",\"icon\":\"n(5573)\"}]},{\"name\":\"family\",\"label\":\"Giađình\",\"items\":[{\"name\":\"crib\",\"label\":\"Cũitrẻem\"}]},{\"name\":\"kitchen_and_dining\",\"label\":\"Nhàbếpvàănuống\",\"items\":[{\"name\":\"kitchen\",\"label\":\"PhòngBếp\",\"icon\":\"n(1543)\"},{\"icon\":\"n(644)\"},{\"name\":\"refrigerator\",\"label\":\"Tủlạnh\",\"icon\":\"n(975)\"},{\"name\":\"inductioncooker\",\"label\":\"Bếptừrời\",\"icon\":\"n(3853)\"},{\"name\":\"microwave\",\"label\":\"Lòvisóng\"},{\"name\":\"hotwaterkettle\",\"label\":\"Ấmđunnướcnóng\"},{\"name\":\"ricemaker\",\"label\":\"Nồicơmđiện\"},{\"name\":\"basicseasoning\",\"label\":\"Giavịcơbản\",\"description\":\"đường,muối...\"},{\"name\":\"fullseasoning\",\"label\":\"Giavịđầyđủ\",\"description\":\"dầuăn,tươngớt...\"},{\"name\":\"dishesandspoons\",\"label\":\"Bátđĩathìa\"},{\"name\":\"dishdetergent\",\"label\":\"Nướcrửabát\"},{\"name\":\"dishwasher\",\"label\":\"Máyrửabát\"},{\"name\":\"coffeemaker\",\"label\":\"Máyphacàphê\"},{\"name\":\"toaster\",\"label\":\"Lònướngbánh\"},{\"name\":\"dinningtable\",\"label\":\"Bànăn\"},{\"name\":\"wineglass\",\"label\":\"Lyuốngrượu\"},{\"name\":\"potsandpots\",\"label\":\"Xoongnồi\"},{\"name\":\"oven\",\"label\":\"Lònướng\"}]},{\"name\":\"outdoor\",\"label\":\"Ngoàitrời\",\"items\":[{\"name\":\"balcony\",\"label\":\"Bancông\",\"icon\":\"n(3598)\"},{\"name\":\"outdoordiningarea\",\"label\":\"Khuvựcăntốingoàitrời\"},{\"name\":\"outdorfurniture\",\"label\":\"Nộithấtngoàitrời\"},{\"name\":\"outdoorkitchen\",\"label\":\"Bếpngoàitrời\"},{\"name\":\"garden\",\"label\":\"Sânvườn\"}]}]}";
    
    public static Filter LoggerFilterOptions()
    {
        var listStr = JsonConvert.DeserializeObject<Filter>(StringJSon);
        return listStr;
    }

    public static long DateTimeToLong(DateTime input)
    {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            long ms = (long)(input - dateTime).TotalMilliseconds;
            long result = ms / 1000;
            return result;
    }

    public static String CheckRating(double rating, long createAt)
    {
        string ratingNew;
        
        DateTime dateNow = DateTime.Now;
        long time = dateNow.ToLong() - createAt;
        
        var day = DatetimeToStringByDay(time.ToDateTime());
        
        if (rating == 0 && day < 10 )
        {
            ratingNew = "New";
        }
        else if(rating != 0)
        {
            ratingNew = rating.ToString();
        }
        else
        {
            ratingNew = "";
        }
        return ratingNew;
    }
    
    public static string ConvertMoney(long money)
    {
        var dec = money;
        return dec.ToString("C", new CultureInfo("vi-VN"));
    }

}
