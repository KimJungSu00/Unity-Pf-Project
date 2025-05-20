using UnityEngine;

public class Calculate : MonoBehaviour
{
   public int Number_1;
   public int Number_2;

   private void Start()
   {
      Debug.Log($"{Number_1} + {Number_2} = {Sum()}");
      Debug.Log($"{Number_1} - {Number_2} = {Subdivide()}");
   }
   
   private int Sum()
   {
      return Number_1 + Number_2;
   }

   private int Subdivide()
   {
      return Number_1 -  Number_2;
   }
   
}
