using System;

namespace Assignment
{
    /// <summary>
    /// Represents a treasure chest.
    /// </summary>
    public class TreasureChest
    {
        private State _state = State.Locked;
        private readonly Material _material;
        private readonly LockType _lockType;
        private readonly LootQuality _lootQuality;

        /// <summary>
        /// Default constructor that initializes the treasure chest with default values.
        /// </summary>
        public TreasureChest()
        {
            _material = Material.Iron;
            _lockType = LockType.Expert;
            _lootQuality = LootQuality.Green;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreasureChest"/> class with the specified state.
        /// </summary>
        /// <param name="state">The initial state of the treasure chest.</param>
        public TreasureChest(State state) : this()
        {
            _state = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreasureChest"/> class with the specified properties.
        /// </summary>
        /// <param name="material">The material of the treasure chest.</param>
        /// <param name="lockType">The lock type of the treasure chest.</param>
        /// <param name="lootQuality">The loot quality of the treasure chest.</param>
        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality)
        {
            _material = material;
            _lockType = lockType;
            _lootQuality = lootQuality;
        }

        /// <summary>
        /// Gets the current state of the treasure chest.
        /// </summary>
        /// <returns>The current state of the treasure chest.</returns>
        public State GetState()
        {
            return _state;
        }

        /// <summary>
        /// Manipulates the treasure chest based on the specified action.
        /// </summary>
        /// <param name="action">The action to perform on the treasure chest.</param>
        /// <returns>The updated state of the treasure chest.</returns>
        public State Manipulate(Action action)
        {
            switch (action)
            {
                case Action.Open:
                    Open();
                    break;
                case Action.Close:
                    Close();
                    break;
                case Action.Lock:
                    Lock();
                    break;
                case Action.Unlock:
                    Unlock();
                    break;
            }

            return _state;
        }

        /// <summary>
        /// Unlocks the treasure chest.
        /// </summary>
        public void Unlock()
        {
            if (_state == State.Locked)
            {
                _state = State.Closed;
            }
        }

        /// <summary>
        /// Locks the treasure chest.
        /// </summary>
        public void Lock()
        {
            if (_state == State.Closed)
            {
                _state = State.Locked;
            }
        }

        /// <summary>
        /// Opens the treasure chest.
        /// </summary>
        public void Open()
        {
            if (_state == State.Closed)
            {
                _state = State.Open;
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest is already open!");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest cannot be opened because it is locked.");
            }
        }

        /// <summary>
        /// Closes the treasure chest.
        /// </summary>
        public void Close()
        {
            if (_state == State.Open)
            {
                _state = State.Closed;
            }
        }

        /// <summary>
        /// Returns a string representation of the treasure chest.
        /// </summary>
        /// <returns>A string representation of the treasure chest.</returns>
        public override string ToString()
        {
            return $"A {_state} chest with the following properties:\nMaterial: {_material}\nLock Type: {_lockType}\nLoot Quality: {_lootQuality}";
        }

        /// <summary>
        /// Displays a list of properties to choose from.
        /// </summary>
        /// <param name="properties">The properties to display.</param>
        private static void ConsoleHelper(params string[] properties)
        {
            Console.WriteLine("Choose from the following properties:");

            for (int i = 0; i < properties.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {properties[i]}");
            }
        }

        /// <summary>
        /// Represents the state of the treasure chest.
        /// </summary>
        public enum State
        {
            Open,
            Closed,
            Locked
        }

        /// <summary>
        /// Represents the actions that can be performed on the treasure chest.
        /// </summary>
        public enum Action
        {
            Open,
            Close,
            Lock,
            Unlock
        }

        /// <summary>
        /// Represents the material of the treasure chest.
        /// </summary>
        public enum Material
        {
            Oak,
            RichMahogany,
            Iron
        }

        /// <summary>
        /// Represents the lock type of the treasure chest.
        /// </summary>
        public enum LockType
        {
            Novice,
            Intermediate,
            Expert
        }

        /// <summary>
        /// Represents the loot quality of the treasure chest.
        /// </summary>
        public enum LootQuality
        {
            Grey,
            Green,
            Purple
        }
    }
}
