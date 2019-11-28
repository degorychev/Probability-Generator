using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probability_generator
{
    /// <summary>
    /// Вероятностный генератор
    /// </summary>
    class Probability_generator
    {
        SortedList<int, ProbabilityGeneratorNode> Probability_list;
        int LastLength;
        Random rnd = new Random();
        public Probability_generator()
        {
            Clear();
        }
        /// <summary>
        /// Очистить список
        /// </summary>
        public void Clear()
        {
            Probability_list = new SortedList<int, ProbabilityGeneratorNode>();
            LastLength = 0;
        }
        /// <summary>
        /// Добавить вариант
        /// </summary>
        /// <param name="variant">Добавить идентификатор</param>
        /// <param name="probability">"Вес" вероятности</param>
        public void AddVariant(object variant, int probability)
        {
            ProbabilityGeneratorNode node = new ProbabilityGeneratorNode(variant, probability);
            Probability_list.Add(LastLength+1, node);
            LastLength += probability;
        }
        /// <summary>
        /// Получить результат
        /// </summary>
        /// <returns>Результат</returns>
        public object Next()
        {
            int key = rnd.Next(1, LastLength+1);
            //Console.WriteLine(key);
            foreach (var i in Probability_list.Keys) //ГОВНОКОД!
                if ((i <= key) && (i + Probability_list[i]._probability >= key))
                    return Probability_list[i]._variant;
            
            return 0;
        }

        private struct ProbabilityGeneratorNode
        {
            public object _variant;
            public int _probability;
            public ProbabilityGeneratorNode(object variant, int probability)
            {
                _variant = variant;
                _probability = probability;
            }
        }
    }    
}
