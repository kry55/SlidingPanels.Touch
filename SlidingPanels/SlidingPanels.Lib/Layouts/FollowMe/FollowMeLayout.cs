// /// Copyright (C) 2013 Pat Laplante & Franc Caico
// ///
// ///	Permission is hereby granted, free of charge, to  any person obtaining a copy 
// /// of this software and associated documentation files (the "Software"), to deal 
// /// in the Software without  restriction, including without limitation the rights 
// /// to use, copy,  modify,  merge, publish,  distribute,  sublicense, and/or sell 
// /// copies of the  Software,  and  to  permit  persons  to   whom the Software is 
// /// furnished to do so, subject to the following conditions:
// ///
// ///		The above  copyright notice  and this permission notice shall be included 
// ///     in all copies or substantial portions of the Software.
// ///
// ///		THE  SOFTWARE  IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
// ///     OR   IMPLIED,   INCLUDING  BUT   NOT  LIMITED   TO   THE   WARRANTIES  OF 
// ///     MERCHANTABILITY,  FITNESS  FOR  A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
// ///     IN NO EVENT SHALL  THE AUTHORS  OR COPYRIGHT  HOLDERS  BE  LIABLE FOR ANY 
// ///     CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT 
// ///     OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION  WITH THE SOFTWARE OR 
// ///     THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// /// -----------------------------------------------------------------------------
//
using System;
using MonoTouch.UIKit;

namespace SlidingPanels.Lib.Layouts.FollowMe
{
	public class FollowMeLayout : Layout
	{
		private UISwipeGestureRecognizer _leftRecognizer;
		private UISwipeGestureRecognizer _rightRecognizer;

		public FollowMeLayout ()
		{
			_leftRecognizer = new UISwipeGestureRecognizer(HandleSwipeLeft);

			_leftRecognizer.Direction = UISwipeGestureRecognizerDirection.Left;
			_rightRecognizer = new UISwipeGestureRecognizer(HandleSwipeRight);
			_rightRecognizer.Direction = UISwipeGestureRecognizerDirection.Right;
		}

		public override void InsertPanelsIntoParentView (UIView parent)
		{
			base.InsertPanelsIntoParentView (parent);
		}

		public override void AddPanelContainer (Containers.Container panelContainer)
		{
			base.AddPanelContainer (panelContainer);
		}

		private void HandleSwipeLeft(UIGestureRecognizer gestureRecognizer)
		{

		}

		private void HandleSwipeRight(UIGestureRecognizer gestureRecognizer)
		{

		}
	}
}
