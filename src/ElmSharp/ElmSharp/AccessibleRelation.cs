/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


namespace ElmSharp.Accessible
{
    /// <summary>
    /// IAccessibleRelation is a interface which defines the relationship between two accessible objects.
    /// </summary>
    public interface IAccessibleRelation
    {

        AccessibleObject Target { get; set; }
        int Type { get; }
    }

    /// <summary>
    /// To define label info for accessible object.
    /// </summary>
    public class LabelledBy : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is LabelledBy.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the LabelledBy type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_LABELLED_BY; }
        }
    }

    /// <summary>
    /// To define label info for accessible object.
    /// </summary>
    public class LabelFor : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is LabelFor.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the LabelFor type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_LABEL_FOR; }
        }
    }

    /// <summary>
    /// To define control relationship for accessible object.
    /// </summary>
    public class ControllerFor : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is ControllerFor.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the ControllerFor type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_CONTROLLER_FOR; }
        }
    }

    /// <summary>
    /// To define control relationship for accessible object.
    /// </summary>
    public class ControlledBy : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is ControlledBy.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the ControlledBy type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_CONTROLLED_BY; }
        }
    }

    /// <summary>
    /// To define member relationship for accessible object.
    /// </summary>
    public class MemberOf : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is MemberOf.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the MemberOf type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_MEMBER_OF; }
        }
    }

    /// <summary>
    /// To define tooltip for accessible object.
    /// </summary>
    public class TooltipFor : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is TooltipFor.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the TooltipFor type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_TOOLTIP_FOR; }
        }
    }

    /// <summary>
    /// To define child for accessible object.
    /// </summary>
    public class ChildOf : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is ChildOf.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the ChildOf type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_NODE_CHILD_OF; }
        }
    }

    /// <summary>
    /// To define parent for accessible object.
    /// </summary>
    public class ParentOf : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is ParentOf.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the ParentOf type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_NODE_PARENT_OF; }
        }
    }

    /// <summary>
    /// To define extend for accessible object.
    /// </summary>
    public class Extended : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is Extended.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the Extended type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_EXTENDED; }
        }
    }

    /// <summary>
    /// To define the custom reading order.
    /// </summary>
    public class FlowsTo : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is FlowsTo.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the FlowsTo type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_FLOWS_TO; }
        }
    }

    /// <summary>
    /// To define the custom reading order.
    /// </summary>
    public class FlowsFrom : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is FlowsFrom.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the FlowsFrom type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_FLOWS_FROM; }
        }
    }

    /// <summary>
    /// To define subwindow for accessible object.
    /// </summary>
    public class SubwindowOf : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is SubwindowOf.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the SubwindowOf type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_SUBWINDOW_OF; }
        }
    }

    /// <summary>
    /// To define embed for accessible object.
    /// </summary>
    public class Embeds : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is Embeds.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the Embeds type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_EMBEDS; }
        }
    }

    /// <summary>
    /// To define embed for accessible object.
    /// </summary>
    public class EmbeddedBy : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is EmbeddedBy.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the EmbeddedBy type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_EMBEDDED_BY; }
        }
    }

    /// <summary>
    /// To define popup for accessible object.
    /// </summary>
    public class PopupFor : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is PopupFor.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the PopupFor type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_POPUP_FOR; }
        }
    }

    /// <summary>
    /// To define parent window for accessible object.
    /// </summary>
    public class ParentWindowOf : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is ParentWindowOf.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the ParentWindowOf type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_PARENT_WINDOW_OF; }
        }
    }

    /// <summary>
    /// To define description for accessible object.
    /// </summary>
    public class DescriptionFor : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is DescriptionFor.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the DescriptionFor type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_DESCRIPTION_FOR; }
        }
    }

    /// <summary>
    /// To define description for accessible object.
    /// </summary>
    public class DescribedBy : IAccessibleRelation
    {
        /// <summary>
        /// Gets or sets the target object which is DescribedBy.
        /// </summary>
        public AccessibleObject Target { get; set; }

        /// <summary>
        /// Gets the DescribedBy type.
        /// </summary>
        public int Type
        {
            get { return (int)Interop.Elementary.Elm_Atspi_Relation_Type.ELM_ATSPI_RELATION_DESCRIBED_BY; }
        }
    }
}