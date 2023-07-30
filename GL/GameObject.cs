﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Framework.GL
{
    public class GameObject
    {
        public Image DisplayImage;
        private GameCell currentCell;
        public GameObjectType type;
        public ProgressBar health;
        
        public GameObject(GameObjectType type, Image displayImage, ProgressBar health)
        {
            this.type = type;
            DisplayImage = displayImage;
            this.health = health;
        }

        public GameObject(GameObjectType type, Image displayImage)
        {
            this.type = type;
            DisplayImage = displayImage;
        }

        public static GameObjectType getGameObjectType(char displayCharacter)
        {

            if (displayCharacter == '|' || displayCharacter == '*')
            {
                return GameObjectType.WALL;
            }

            if (displayCharacter == '.')
            {
                return GameObjectType.REWARD;
            }

            return GameObjectType.NONE;
        }


        public GameCell CurrentCell
        {
            get => currentCell;
            set
            {
                currentCell = value;
                currentCell.setGameObject(this);
            }
        }
    }

    public enum GameObjectType
    {
        WALL,

        PLAYER,

        ENEMY,

        REWARD,

        FIRE,

        NONE
    }
}
