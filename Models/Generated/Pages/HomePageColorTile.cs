﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.Custom;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(HomePageColorTile.CLASS_NAME, typeof(HomePageColorTile))]

namespace CMS.DocumentEngine.Types.Custom
{
    /// <summary>
    /// Represents a content item of type HomePageColorTile.
    /// </summary>
    public partial class HomePageColorTile : TreeNode
    {
        #region "Constants and variables"

        /// <summary>
        /// The name of the data class.
        /// </summary>
        public const string CLASS_NAME = "custom.HomePageColorTile";


        /// <summary>
        /// The instance of the class that provides extended API for working with HomePageColorTile fields.
        /// </summary>
        private readonly HomePageColorTileFields mFields;

        #endregion


        #region "Properties"

        /// <summary>
        /// HomePageColorTileID.
        /// </summary>
        [DatabaseIDField]
        public int HomePageColorTileID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("HomePageColorTileID"), 0);
            }
            set
            {
                SetValue("HomePageColorTileID", value);
            }
        }


        /// <summary>
        /// Tile Text.
        /// </summary>
        [DatabaseField]
        public string Text
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Text"), "");
            }
            set
            {
                SetValue("Text", value);
            }
        }


        /// <summary>
        /// Button Text.
        /// </summary>
        [DatabaseField]
        public string ButtonText
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ButtonText"), "");
            }
            set
            {
                SetValue("ButtonText", value);
            }
        }


        /// <summary>
        /// Background Color.
        /// </summary>
        [DatabaseField]
        public string BackgroundColor
        {
            get
            {
                return ValidationHelper.GetString(GetValue("BackgroundColor"), "");
            }
            set
            {
                SetValue("BackgroundColor", value);
            }
        }


        /// <summary>
        /// Background Image.
        /// </summary>
        [DatabaseField]
        public string BackgroundImage
        {
            get
            {
                return ValidationHelper.GetString(GetValue("BackgroundImage"), "");
            }
            set
            {
                SetValue("BackgroundImage", value);
            }
        }


        /// <summary>
        /// Gets an object that provides extended API for working with HomePageColorTile fields.
        /// </summary>
        [RegisterProperty]
        public HomePageColorTileFields Fields
        {
            get
            {
                return mFields;
            }
        }


        /// <summary>
        /// Provides extended API for working with HomePageColorTile fields.
        /// </summary>
        [RegisterAllProperties]
        public partial class HomePageColorTileFields : AbstractHierarchicalObject<HomePageColorTileFields>
        {
            /// <summary>
            /// The content item of type HomePageColorTile that is a target of the extended API.
            /// </summary>
            private readonly HomePageColorTile mInstance;


            /// <summary>
            /// Initializes a new instance of the <see cref="HomePageColorTileFields" /> class with the specified content item of type HomePageColorTile.
            /// </summary>
            /// <param name="instance">The content item of type HomePageColorTile that is a target of the extended API.</param>
            public HomePageColorTileFields(HomePageColorTile instance)
            {
                mInstance = instance;
            }


            /// <summary>
            /// HomePageColorTileID.
            /// </summary>
            public int ID
            {
                get
                {
                    return mInstance.HomePageColorTileID;
                }
                set
                {
                    mInstance.HomePageColorTileID = value;
                }
            }


            /// <summary>
            /// Tile Text.
            /// </summary>
            public string Text
            {
                get
                {
                    return mInstance.Text;
                }
                set
                {
                    mInstance.Text = value;
                }
            }


            /// <summary>
            /// Button Text.
            /// </summary>
            public string ButtonText
            {
                get
                {
                    return mInstance.ButtonText;
                }
                set
                {
                    mInstance.ButtonText = value;
                }
            }


            /// <summary>
            /// Background Color.
            /// </summary>
            public string BackgroundColor
            {
                get
                {
                    return mInstance.BackgroundColor;
                }
                set
                {
                    mInstance.BackgroundColor = value;
                }
            }


            /// <summary>
            /// Background Image.
            /// </summary>
            public string BackgroundImage
            {
                get
                {
                    return mInstance.BackgroundImage;
                }
                set
                {
                    mInstance.BackgroundImage = value;
                }
            }
        }

        #endregion


        #region "Constructors"

        /// <summary>
        /// Initializes a new instance of the <see cref="HomePageColorTile" /> class.
        /// </summary>
        public HomePageColorTile() : base(CLASS_NAME)
        {
            mFields = new HomePageColorTileFields(this);
        }

        #endregion
    }
}