namespace MeetingApp.Models;

public static class Repository
{
    private static List<UserInfo> userInfo = new List<UserInfo>(){};
        
    static Repository(){
        userInfo.Add(new UserInfo(){Id = 1,Name = "Kenan", Phone = "555-555-5555", Email = "VgQ5r@example.com",WillAttend = true});
        userInfo.Add(new UserInfo(){Id = 2,Name = "John", Phone = "555-555-5555", Email = "example@example.com",WillAttend = false});
        userInfo.Add(new UserInfo(){Id = 3,Name = "Jane", Phone = "555-555-5555", Email = "example@example.com",WillAttend = true});
    }
    public static List<UserInfo> GetUserInfo() => userInfo;
    public static void AddUserInfo(UserInfo userinfo){
         userinfo.Id = userInfo.Count() + 1;
         userInfo.Add(userinfo);
    }

    public static UserInfo? GetById(int id) => userInfo.FirstOrDefault(i=> i.Id == id);
}