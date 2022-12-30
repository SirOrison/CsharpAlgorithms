using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class QuestLogic
    {
        public bool CanFastAttack(bool knightIsAwake)
        {
            if (knightIsAwake)
            {
                return false;
            }
            
            return true;
            //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");
        }

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            if (knightIsAwake || archerIsAwake || prisonerIsAwake) 
            {
                return true;
            }

            return false;
            //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            if(!archerIsAwake && prisonerIsAwake)
            {
                return true;
            }

            return false;
            //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
        }

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if(prisonerIsAwake && petDogIsPresent && !archerIsAwake && !knightIsAwake)
            {
                return true;
            }
            else if(!petDogIsPresent && prisonerIsAwake && !archerIsAwake && !knightIsAwake )
            {
                return true;
            }
            else if (!petDogIsPresent && !prisonerIsAwake && !archerIsAwake && !knightIsAwake)
            {
                return false;
            }
            else if(!prisonerIsAwake && petDogIsPresent && !archerIsAwake && !knightIsAwake)
            {
                return true;
            }
            else if(!prisonerIsAwake && petDogIsPresent && !archerIsAwake && knightIsAwake)
            {
                return true;
            }
            else if (prisonerIsAwake && petDogIsPresent && !archerIsAwake && knightIsAwake)
            {
                return true;
            }
            else
            {
                return false;
            }

            //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
        }
    }
}
