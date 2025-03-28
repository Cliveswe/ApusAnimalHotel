﻿using AnimalMotel.Model.FeedingPlan;
using System;
using System.Runtime.Serialization;
///
///
/// Date 2019-02-20
/// 
/// A animal object that has a "is a" relationship to the class Insect. This class maintains
/// data about a insects larval status.
/// 
namespace AnimalMotel.Model.Animals.Insects
    {
    /// <summary>
    /// The Bee class contains properties and methods that are common to all bees.
    /// </summary>
    /// <seealso cref="AnimalMotel.Model.Animals.Insect" />
    [Serializable]
    public class Bee : Insect
        {

        #region Class properties        
        /// <summary>
        /// Gets or sets the larval phase.
        /// </summary>
        /// <value>
        /// Larval phase.
        /// </value>
        public bool LarvalPhase
            {
            get
                {
                return _larvalPhase;
                }
            set
                {
                _larvalPhase = value;
                }
            }
        private bool _larvalPhase;

        private EaterEnum diet;

        public FoodSchedule dietRequirements;
        /// <summary>
        /// Used in Serialization as a key in the key, value pair.
        /// </summary>
        private enum Fields { LarvalPhase, FoodSchedule }
        #endregion

        /// <summary>
        /// Initializes a copy instance of the <see cref="Bee"/> class.
        /// </summary>
        /// <param name="other">The other bee that is to be copied.</param>
        public Bee(Bee other) : base((Insect)other)
            {
            this.LarvalPhase = other.LarvalPhase;
            this.dietRequirements = other.dietRequirements;
            this.diet = other.diet;
            }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bee"/> class.
        /// </summary>
        /// <param name="name">Name of the bee.</param>
        /// <param name="age">The age.</param>
        /// <param name="iD">The bee's identifier.</param>
        /// <param name="larvalPhase">The bee's larval phase.</param>
        /// <param name="isPoisonous">The bee is poisonous.</param>
        public Bee(string name, double age, string iD, string gender, bool isPoisonous, bool larvalPhase) :
        base(name, age, iD, gender, isPoisonous)
            {
            LarvalPhase = larvalPhase;
            SetDiet();
            }
        /// <summary>
        /// Set the diet of the Dolphin.
        /// </summary>
        private void SetDiet()
            {
            diet = EaterEnum.Herbivore;
            dietRequirements = new FoodSchedule();
            PopulateFoodSchedule();
            }
        private void PopulateFoodSchedule()
            {
            dietRequirements.AddFoodScheduleItem("Bee diet.");
            dietRequirements.AddFoodScheduleItem("The honey bee diet consists of two staples, both of which are produced by flowers.");
            dietRequirements.AddFoodScheduleItem("Nectar and Pollen.");
            dietRequirements.AddFoodScheduleItem("Sugar syrup can be fed to them during winter.");
            dietRequirements.AddFoodScheduleItem("Alternatively if it is too cold, use fondant and sugar candy.");
            }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
            {
            return "\nLarval phase: " + LarvalPhase + base.ToString();
            }
        /// <summary>
        /// Gets the type of the eater.
        /// </summary>
        /// <returns></returns>
        public override EaterEnum GetEaterType()
            {
            return diet;
            }
        /// <summary>
        /// Gets the food schedule.
        /// </summary>
        /// <returns></returns>
        public override FoodSchedule GetFoodSchedule()
            {
            return new FoodSchedule(this.dietRequirements);
            }
        /// <summary>
        /// Gets the type of the species.
        /// </summary>
        /// <returns></returns>
        public override string GetSpeciesType()
            {

            return this.GetType().Name;
            }

        #region Serialization
        /// <summary>
        /// Serialize the object.
        /// </summary>
        /// <param name="info">Serialize information from the object in a key value pair.</param>
        /// <param name="context"></param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
            {
            base.GetObjectData(info, context);
            info.AddValue(Fields.LarvalPhase.ToString(), LarvalPhase);
            info.AddValue(Fields.FoodSchedule.ToString(), dietRequirements);
            }
        /// <summary>
        /// De-serialize the object to restore its content.
        /// </summary>
        /// <param name="info">Serialize information get the object using a key value pair.</param>
        /// <param name="context"></param>
        public Bee(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            LarvalPhase = (bool)info.GetValue(Fields.LarvalPhase.ToString(), typeof(bool));
            dietRequirements = (FoodSchedule)info.GetValue(Fields.FoodSchedule.ToString(), typeof(FoodSchedule));
            }
        [OnDeserialized]
        void OnDeserialized(StreamingContext context)
            {
            // SetDiet();
            }
        public Bee()
            {

            }
        #endregion
        }
    }

