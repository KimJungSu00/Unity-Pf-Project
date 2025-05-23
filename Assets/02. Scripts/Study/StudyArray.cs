using System;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
   private int [] arrayNumber = new int [3];

   private void Start()
   {
      var value = 0;
      for (var i = 0; i < 3; i++)
      {
         arrayNumber[i] = value++;
      }
      for (var i = 0; i < 3; i++)
      {
         Debug.Log(arrayNumber[i]);
      }
   }
}
