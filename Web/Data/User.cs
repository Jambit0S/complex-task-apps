using System; 
public class User 
{
    public string log{get;set;}
    public string pas{get;set;}
    public int id;

    public User()
    {
        id=0;
        log="ANON";
        pas="ANON";

    }
    public User(int id, string l, string p)
    {
        this.id=id;
        log=l;
        pas=p;
    }
    public bool IsExist()
    {
        //if() Проверка существует ли данный юзер в бд
        //{return true;}
        if(log=="test"&&pas=="test")
            return true;
        


        return false;
    }

}