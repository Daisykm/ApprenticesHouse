using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipSystem : MonoBehaviour
{
   private static TooltipSystem current;

   public Tooltip tooltip;
   public void Awake()
   {
      current = this;
   }

   public static void Show( string content, string header = "")
   {
      current.tooltip.gameObject.SetActive(true);
      current.tooltip.SetText(content, header);
   }

   public static void Hide()
   {
      current.tooltip.gameObject.SetActive(false);
   }
}
