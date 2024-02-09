using System;
using UnityEngine;

namespace Decorator
{
    public class CharacterStatsSelecter : MonoBehaviour
    {
        [SerializeField] private CharacterStatsData _data;
        private �haracter _character;

        private bool SpeciesIsSelected;
        private bool SpecializationIsSelected;

        void Awake()
        {
            _character = new �haracter(new PlayerStats(
                _data.Strength, _data.Intelligence, _data.Dexterity));

            Debug.Log($"Strength:{_character.Stat.Strength} Intelligence:{_character.Stat.Intelligence} Dexterity:{_character.Stat.Dexterity}");
        }

        void Update()
        {
            if(SpeciesIsSelected == false)
            {
                if(Input.GetKeyDown(KeyCode.Alpha1))
                    SelectSpecies(SpeciesType.Human);

                if(Input.GetKeyDown(KeyCode.Alpha2))
                    SelectSpecies(SpeciesType.Elf);

                if(Input.GetKeyDown(KeyCode.Alpha3))
                    SelectSpecies(SpeciesType.Ork);
            }
            else if(SpecializationIsSelected == false)
            {
                if(Input.GetKeyDown(KeyCode.Alpha1))
                    SelectSpecialization(SpecializationType.Barbarian);

                if(Input.GetKeyDown(KeyCode.Alpha2))
                    SelectSpecialization(SpecializationType.Magician);

                if(Input.GetKeyDown(KeyCode.Alpha3))
                    SelectSpecialization(SpecializationType.Thief);
            }
            else
            {
                if(Input.GetKeyDown(KeyCode.Alpha1))
                    SelectPassiveAbilities(PassiveAbilitiesType.Brisk);

                if(Input.GetKeyDown(KeyCode.Alpha2))
                    SelectPassiveAbilities(PassiveAbilitiesType.Jock);

                if(Input.GetKeyDown(KeyCode.Alpha3))
                    SelectPassiveAbilities(PassiveAbilitiesType.Resourceful);
            }
        }

        public void SelectSpecies(SpeciesType type)
        {
            switch(type)
            {
                case SpeciesType.Human:
                    _character.ChangeStats(new Human(_character.Stat));
                    Debug.Log("������ Human");
                    break;

                case SpeciesType.Elf:
                    _character.ChangeStats(new Elf(_character.Stat));
                    Debug.Log("������ Elf");
                    break;

                case SpeciesType.Ork:
                    _character.ChangeStats(new Ork(_character.Stat));
                    Debug.Log("������ Ork");
                    break;

                default:
                    throw new NotImplementedException("This type not implemented");
            }

            SpeciesIsSelected = true;
            Debug.Log($"Strength:{_character.Stat.Strength} Intelligence:{_character.Stat.Intelligence} Dexterity:{_character.Stat.Dexterity}");
        }

        public void SelectSpecialization(SpecializationType type)
        {
            switch(type)
            {
                case SpecializationType.Barbarian:
                    _character.ChangeStats(new Barbarian(_character.Stat));
                    Debug.Log("������ Barbarian");
                    break;

                case SpecializationType.Magician:
                    _character.ChangeStats(new Magician(_character.Stat));
                    Debug.Log("������ Magician");
                    break;

                case SpecializationType.Thief:
                    _character.ChangeStats(new Thief(_character.Stat));
                    Debug.Log("������ Thief");
                    break;

                default:
                    throw new NotImplementedException("This type not implemented");
            }

            SpecializationIsSelected = true;
            Debug.Log($"Strength:{_character.Stat.Strength} Intelligence:{_character.Stat.Intelligence} Dexterity:{_character.Stat.Dexterity}");
        }

        public void SelectPassiveAbilities(PassiveAbilitiesType type)
        {
            switch(type)
            {
                case PassiveAbilitiesType.Brisk:
                    _character.ChangeStats(new Brisk(_character.Stat));
                    Debug.Log("������ Brisk");
                    break;

                case PassiveAbilitiesType.Jock:
                    _character.ChangeStats(new Jock(_character.Stat));
                    Debug.Log("������ Jock");
                    break;

                case PassiveAbilitiesType.Resourceful:
                    _character.ChangeStats(new Resourceful(_character.Stat));
                    Debug.Log("������ Resourceful");
                    break;

                default:
                    throw new NotImplementedException("This type not implemented");
            }
            Debug.Log($"Strength:{_character.Stat.Strength} Intelligence:{_character.Stat.Intelligence} Dexterity:{_character.Stat.Dexterity}");
        }
    }
}