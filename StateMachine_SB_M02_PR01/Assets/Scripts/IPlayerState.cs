using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public interface IPlayerState
{
    void Enter(Player player);
    void Handle(Player player);
   
 }




