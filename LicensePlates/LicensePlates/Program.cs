using System;
using System.Collections.Generic;

namespace LicensePlates
{
    public class MyDMV
    {

        static void Main()
        {
            HashSet<DMV> set = new HashSet<DMV>();

            bool DidItAddTheItem = false;

            DMV myDMV = new DMV();

            TagInfo myTag = new TagInfo();

            myTag.TagNumber = "4503";
            myTag.TagState = "South Carolina";
            myDMV.AddTag(myTag);
            DidItAddTheItem = set.Add(myDMV);
            Console.WriteLine(DidItAddTheItem);

            TagInfo myTag2 = new TagInfo();
            myTag2.TagNumber = "4504";
            myTag2.TagState = "North Carolina";
            myDMV.AddTag(myTag);
            DidItAddTheItem = set.Add(myDMV);
            Console.WriteLine(DidItAddTheItem);

            myDMV.ShowTags();

            foreach (var item in set)
            {
                Console.WriteLine(item.);
            }

        }
    }
}
public class DMV
{
   
    public HashSet<TagInfo> mySet = new HashSet<TagInfo>();

    public void AddTag(TagInfo TagNumber)
    {
        bool result = mySet.Add(TagNumber);
       if (result==false)
        {
            Console.WriteLine("Tag number already exists");
        }
        else
        {
            Console.WriteLine("Please register this tag to the system");
        }
    }
   public void ShowTags()
    {
        Console.WriteLine("You have this many tags: " +
                  mySet.Count);
    }
}
public class TagInfo
{
    public string TagNumber { get; set; }
    public string TagState { get; set; }

    public override bool Equals(object obj)
    {
        TagInfo newClass = obj as TagInfo;

        return this.TagNumber.Equals(newClass.TagNumber);
    }

    public override int GetHashCode()
    {
        return this.TagNumber.GetHashCode();
    }

}