using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    #region task1
    //task1
    //public class GameObjectCollection<T>
    //{
    //    private List<T> gameObjects = new List<T>();

    //    public void Add(T gameObject)
    //    {
    //        gameObjects.Add(gameObject);
    //    }

    //    public void Remove(T gameObject)
    //    {
    //        gameObjects.Remove(gameObject);
    //    }

    //    public T Find(Predicate<T> match)
    //    {
    //        return gameObjects.Find(match);
    //    }

    //    public List<T> FindAll(Predicate<T> match)
    //    {
    //        return gameObjects.FindAll(match);
    //    }

    //    public void Clear()
    //    {
    //        gameObjects.Clear();
    //    }
    //}
    #endregion
    #region task2
    //task2
    //public interface ICharacter<T>
    //{
    //    void Attack(T hedef);
    //    void TakeDamage(int hasar);
    //    void Heal(int iyileşmeMiqdarı);
    //}
    //public class Savashci :ICharacter<T>
    //{
    //    public void Attack() 
    //    {
    //        Console.WriteLine("Hedefe saldiri edir");
    //    }
    //    public void TakeDamage()
    //    {
    //        Console.WriteLine("Cani saldirdigi qeder azalar");
    //    }
    //    public void Heal()
    //    {
    //        Console.WriteLine("Cani sagalma miqdarina gore artar");
    //    }
    //}
    #endregion
    #region task3
    //task3
    //public class Inventory<T> where T : IComparable<T>
    //{
    //    private List<T> items;

    //    public Inventory()
    //    {
    //        items = new List<T>();
    //    }

    //    public void Add(T item)
    //    {
    //        items.Add(item);
    //    }

    //    public bool Remove(T item)
    //    {
    //        return items.Remove(item);
    //    }

    //    public void Sort()
    //    {
    //        items.Sort();
    //    }

    //    public List<T> GetAllItems()
    //    {
    //        return items;
    //    }
    //}
    #endregion
    #region task4
    //task4
    //public static T MaxHealth<T>() where T : Component
    //{
    //    T max = null;
    //    float maxHealth = float.MinValue;
    //    foreach (T element )
    //    {
    //        return (T)element;
    //    }
    //    return max;
    //}
    #endregion
    #region task5
    //task5
    //public class Leaderboard<T>
    //{
    //    private Dictionary<T, int> leaderboard;

    //    public Leaderboard()
    //    {
    //        leaderboard = new Dictionary<T, int>();
    //    }

    //    public void AddPlayer(T player, int score)
    //    {
    //        leaderboard[player] = score;
    //    }

    //    public void RemovePlayer(T player)
    //    {
    //        leaderboard.Remove(player);
    //    }

    //    public void SortByScoreDescending()
    //    {
    //        leaderboard = leaderboard.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
    //    }

    //    public List<T> GetPlayers()
    //    {
    //        return leaderboard.Keys.ToList();
    //    }

    //    public int GetScore(T player)
    //    {
    //        if (leaderboard.TryGetValue(player, out int score))
    //        {
    //            return score;
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }
    //}
    #endregion
    #region task6
    //task6
    //public class Game
    //{
    //    public string Name { get; set; }
    //    public int Level { get; set; }
    //    public int Score { get; set; }
    //}
    //public static class GameExtensions
    //{
    //    public static IEnumerable<Game> SortBy(this IEnumerable<Game> games, string property)
    //    {
    //        switch (property.ToLower())
    //        {
    //            case "name":
    //                return games.OrderBy(g => g.Name);
    //            case "level":
    //                return games.OrderBy(g => g.Level);
    //            case "score":
    //                return games.OrderByDescending(g => g.Score);
    //            default:
    //                throw new ArgumentException($"Invalid property '{property}'");
    //        }
    //    }
    //}
    #endregion


}








