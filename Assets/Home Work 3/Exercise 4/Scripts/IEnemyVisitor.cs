﻿namespace HomeWork3.Exercise4
{
    public interface IEnemyVisitor
    {
        void Visit(Ork ork);
        void Visit(Human human);
        void Visit(Elf elf);
        void Visit(Enemy enemy);
    }
}
