using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class School
    {
        private string name;
        private Canteen canteen;
        private List<Class> clasList;
        public School()
        {
            this.name = null;
            this.canteen = null;
            this.clasList = new List<Class>();
        }
        public School(string name)
        {
            this.name = name;
            this.clasList = new List<Class>();
        }
        public School(string name, Canteen canteen, List<Class> clasList)
        {
            this.name = name;
            this.canteen = canteen;
            this.clasList = clasList;
        }
        public string Name
        {
            set { if (this.name == null) this.name = value; }
            get { return this.name; }
        }
        public Canteen Canteen
        {
            set { if (this.canteen == null) this.canteen = value; }
            get { return this.canteen; }
        }
        public List<Class> ClasList
        {
            set { if (this.clasList == null) this.clasList = value; }
            get { return this.clasList; }
        }
        public void Accept(Class Class, Human human)
        {
            for (int i = 0; i < this.clasList.Count; i++)
                if (Class == this.clasList[i])
                {
                    this.clasList[i].ListofHuman.Add(human);
                    break;
                }
        }
        public void Accept(Class Class, List<Human> human)
        {
            for (int i = 0; i < this.clasList.Count; i++)
                if (Class == this.clasList[i])
                {
                    for (int j = 0; j < human.Count; j++)
                    { this.clasList[i].ListofHuman.Add(human[j]); }
                    break;
                }
        }
        /* Ты хочешь так, но ведь так будет потрачено больше ресурсов, почему... почему нужно делать такие жертвы ради логики?
        public void Accept(Class Class, List<Human> human)
        {
            for (int i = 0; i < human.Count; i++)
                {
                    Accept(Class, human[i])
                }
        }*/
        public void Kick(Human human)
        {
            for (int i = 0; i < this.clasList.Count; i++)
                for (int j = 0; j < this.clasList[i].ListofHuman.Count; j++)
                    if (human == this.clasList[i].ListofHuman[j])
                    {
                        this.clasList[i].ListofHuman.Remove(human);
                        break;
                    }
        }
        public void ChangeClass(Class NewClass, Human human)
        {
            //или ты все таки хотел что бы я хранил в челе ссылку на его класс?
            for (int i = 0; i < this.clasList.Count; i++)
                for (int j = 0; j < this.clasList[i].ListofHuman.Count; j++)
                    if (human == this.clasList[i].ListofHuman[j])
                    {
                        this.clasList[i].ListofHuman.Remove(human);
                        break;
                    }
            NewClass.ListofHuman.Add(human);
        }
    }
}
