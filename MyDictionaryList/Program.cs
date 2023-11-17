using MyDictionaryList;



DictionaryList<int,string> dictionaryList = new DictionaryList<int, string>();
dictionaryList.Add( 1 ,"Ahmet");
dictionaryList.Add( 2 ,"Berk");


for (int i = 0; i < dictionaryList.Length; i++)
{
    Console.WriteLine( dictionaryList._Keys[i] + " " + dictionaryList._Values[i]);

}