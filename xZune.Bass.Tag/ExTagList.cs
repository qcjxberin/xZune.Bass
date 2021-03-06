﻿// Project: xZune.Bass (https://github.com/higankanshi/xZune.Bass)
// Filename: ExTagList.cs
// Version: 20160318

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using xZune.Bass.Tag.Interop.Core;
using xZune.Bass.Tag.Modules;

namespace xZune.Bass.Tag
{
    /// <summary>
    ///     ExTag list accessor for <see cref="TagsManager" />.
    /// </summary>
    public class ExTagList : IReadOnlyList<ExtTag>
    {
        private readonly TagsManager _target;

        internal ExTagList(TagsManager tag)
        {
            _target = tag;
        }

        /// <summary>
        ///     Is it read only?
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        ///     Get enumerator for <see cref="ExTagList" />.
        /// </summary>
        /// <returns>Enumerator.</returns>
        public IEnumerator<ExtTag> GetEnumerator()
        {
            return new ExTagListEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        ///     Get <see cref="ExtTag" /> count of <see cref="TagsManager" />.
        /// </summary>
        public int Count => TagsLibCoreModule.GetTagCountFunction.Delegate(_target.Handle, TagType.Automatic);

        /// <summary>
        ///     Get <see cref="ExtTag" /> from index.
        /// </summary>
        /// <param name="index">Index of tag which you want to get.</param>
        /// <returns>Tag.</returns>
        public ExtTag this[int index]
        {
            get
            {
                ExtTag result = new ExtTag();
                TagsLibCoreModule.GetExTagByIndexFunction.Delegate(_target.Handle, index, TagType.Automatic,
                    ref result.Struct);
                return result;
            }
        }

        /// <summary>
        ///     Add a new <see cref="ExtTag" /> to <see cref="TagsManager" />.
        /// </summary>
        /// <param name="item">Tag which you want to add.</param>
        public void Add(ExtTag item)
        {
            TagsLibCoreModule.AddExTagFunction.Delegate(_target.Handle, TagType.Automatic, ref item.Struct);
        }

        /// <summary>
        ///     Clear all tag from <see cref="TagsManager" />.
        /// </summary>
        public void Clear()
        {
            for (int i = 0; i < Count; i++)
            {
                TagsLibCoreModule.DeleteTagByIndexFunction.Delegate(_target.Handle, i, TagType.Automatic);
            }
        }

        /// <summary>
        ///     Check if <see cref="TagsManager" /> contains a tag.
        /// </summary>
        /// <param name="item">Tag which you want to check.</param>
        /// <returns></returns>
        public bool Contains(ExtTag item)
        {
            return this.Any(t => t == item);
        }

        /// <summary>
        ///     Copy all <see cref="ExtTag" /> to a array.
        /// </summary>
        /// <param name="array">Array which you want to copy to.</param>
        /// <param name="arrayIndex">The first index of array.</param>
        public void CopyTo(ExtTag[] array, int arrayIndex)
        {
            foreach (ExtTag tag in this)
            {
                array[arrayIndex] = tag;
                arrayIndex++;
            }
        }

        /// <summary>
        ///     Remove a tag from <see cref="TagsManager" />.
        /// </summary>
        /// <param name="item">Tag which you want to remove.</param>
        /// <returns>True for success, false for fail.</returns>
        public bool Remove(ExtTag item)
        {
            if (!Contains(item))
                return false;

            return TagsLibCoreModule.DeleteTagByIndexFunction.Delegate(_target.Handle, item.Index, TagType.Automatic);
        }

        /// <summary>
        ///     Get index of a tag.
        /// </summary>
        /// <param name="item">Tag which you want to check.</param>
        /// <returns>Index of tag.</returns>
        public int IndexOf(ExtTag item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i] == item)
                    return i;
            }

            return -1;
        }

        /// <summary>
        ///     Save all changes of <see cref="ExtTag" />, it will recover tag which has same name as <see cref="ExtTag.Name" />.
        /// </summary>
        /// <param name="item">Tag which you want to save changes.</param>
        /// <returns></returns>
        public bool Change(ExtTag item)
        {
            return TagsLibCoreModule.SetExTagFunction.Delegate(_target.Handle, TagType.Automatic, ref item.Struct);
        }

        /// <summary>
        ///     Remove tag at index.
        /// </summary>
        /// <param name="index">Index of tag which you want to remove.</param>
        public void RemoveAt(int index)
        {
            TagsLibCoreModule.DeleteTagByIndexFunction.Delegate(_target.Handle, index, TagType.Automatic);
        }

        private class ExTagListEnumerator : IEnumerator<ExtTag>
        {
            private int _index = -1;

            private ExTagList _target;

            public ExTagListEnumerator(ExTagList list)
            {
                _target = list;
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (_index < _target.Count - 1)
                {
                    _index++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                _index = -1;
            }

            public ExtTag Current => _target[_index];

            object IEnumerator.Current => Current;
        }
    }
}