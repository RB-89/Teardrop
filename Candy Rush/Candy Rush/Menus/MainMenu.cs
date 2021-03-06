﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Experia.Framework;
using Experia.Framework.UI;

namespace CandyRush
{
    public class MainMenu : BaseMenuScreen
    {
        public Sprite m_Background;
        public Sprite m_Moon;
        public Sprite m_Grave;
        public Sprite m_Pumpkin;
        public Sprite m_Title;

        public ImageButton m_PlayImage;
        public ImageButton m_OptionsImage;
        public ImageButton m_CreditsImage;
        public ImageButton m_ExitImage;

        public MainMenu()
        {
            m_Background = new Sprite();
            m_Background.Texture = ContentLoader.Instance.Load<Texture2D>(ContentContainer.UI, @"Content\\Graphics\\Background");
            m_Background.Position = ExperiaHelper.Instance.PositionByResolution(new Vector2(0.0f, 0.0f));
            m_Moon = new Sprite();
            m_Moon.Texture = ContentLoader.Instance.Load<Texture2D>(ContentContainer.UI, @"Content\\Graphics\\Moon");
            m_Moon.Position = ExperiaHelper.Instance.PositionByResolution(new Vector2(78.0f, 2.0f));

            m_Grave = new Sprite();
            m_Grave.Texture = ContentLoader.Instance.Load<Texture2D>(ContentContainer.UI, @"Content\\Graphics\\Grave");
            m_Grave.Position = ExperiaHelper.Instance.PositionByResolution(new Vector2(50.0f, 10.0f));

            m_Pumpkin = new Sprite();
            m_Pumpkin.Texture = ContentLoader.Instance.Load<Texture2D>(ContentContainer.UI, @"Content\\Graphics\\Pumpkin");
            m_Pumpkin.Position = ExperiaHelper.Instance.PositionByResolution(new Vector2(26.0f, 42.0f));

            m_Title = new Sprite();
            m_Title.Texture = ContentLoader.Instance.Load<Texture2D>(ContentContainer.UI, @"Content\\Graphics\\Title");
            m_Title.Position = ExperiaHelper.Instance.PositionByResolution(new Vector2(5.0f, 5.0f));


            m_PlayImage = new ImageButton(ContentLoader.Instance.Load<Texture2D>(ContentContainer.UI, @"Content\\Graphics\\Play"),
                ExperiaHelper.Instance.PositionByResolution(new Vector2(68f, 30f)));
            m_OptionsImage = new ImageButton(ContentLoader.Instance.Load<Texture2D>(ContentContainer.UI, @"Content\\Graphics\\Options"),
                ExperiaHelper.Instance.PositionByResolution(new Vector2(62.0f, 45.0f)));
            m_CreditsImage = new ImageButton(ContentLoader.Instance.Load<Texture2D>(ContentContainer.UI, @"Content\\Graphics\\Credits"),
                ExperiaHelper.Instance.PositionByResolution(new Vector2(63.0f, 62.0f)));
            m_ExitImage = new ImageButton(ContentLoader.Instance.Load<Texture2D>(ContentContainer.UI, @"Content\\Graphics\\Exit"),
                ExperiaHelper.Instance.PositionByResolution(new Vector2(67.0f, 79.0f)));
        }

        public override void Update()
        {
            if (m_PlayImage.Clicked)
            {
                MenuManager.Instance.SwitchMenu("Play");
            }

            if (m_OptionsImage.Clicked)
            {
                MenuManager.Instance.SwitchMenu("Options");
            }

            if (m_CreditsImage.Clicked)
            {
                //to implement
            }

            if (m_ExitImage.Clicked)
            {
                GameStateManager.Instance.ExitGame();
            }
        }

        public override void Draw(GraphicsManager graphics)
        {
            m_Background.Draw(graphics.SpriteBatch);
            m_Moon.Draw(graphics.SpriteBatch);
            m_Pumpkin.Draw(graphics.SpriteBatch);
            m_Grave.Draw(graphics.SpriteBatch);
            m_Title.Draw(graphics.SpriteBatch);

            m_PlayImage.Draw(graphics);
            m_OptionsImage.Draw(graphics);
            m_CreditsImage.Draw(graphics);
            m_ExitImage.Draw(graphics);
        }
    }
}