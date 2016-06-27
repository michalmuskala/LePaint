using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LePaint.Brushes;

namespace LePaint.Canvas
{
    public class CanvasPresenter
    {
        ICanvasView view;
        ICanvas model;

        private string currentOption;
        private IBrush currentBrush;
        private Pen currentPen = new Pen(Color.Black, 1);
        private Dictionary<string, IBrush> brushes = new Dictionary<string, IBrush>();

        public CanvasPresenter(ICanvasView view, ICanvas model)
        {
            this.view = view;
            view.BrushSelected += OnBrushSelected;
            view.PathUpdated += OnPathUpdated;
            view.SelectedColor += OnColorSelected;
            view.SelectedSize += OnSizeSelected;
            view.OptionSelected += OnOptionSelected;
            view.Commit += OnCommit;
            this.model = model;

            brushes.Add("line", new Brushes.Line());
            // Select default brush
            currentBrush = brushes["line"];
        }

        private void OnOptionSelected(object sender, string e)
        {
            currentOption = e;
        }

        private void OnCommit(object sender, EventArgs e)
        {
            model.CommitTemporaryObjects();
        }

        private void OnSizeSelected(object sender, int e)
        {
            currentPen = new Pen(currentPen.Color, e);
        }

        private void OnColorSelected(object sender, Color e)
        {
            currentPen = new Pen(e, currentPen.Width);
        }

        private void OnPathUpdated(object sender, IEnumerable<Point> e)
        {
            if (currentBrush != null)
            {
                currentBrush.Pen = currentPen;
                currentBrush.Option = currentOption;
                model.RefreshTemporaryObjects(currentBrush, e);
                view.NextObjects = model.Objects;
            }
        }

        private void OnBrushSelected(object sender, string brushName)
        {
            currentBrush = brushes[brushName];
            view.ShowColorAndSizeSelectors = currentBrush.AffectedByPen;
            view.ShowFilledSelector = currentBrush.AffectedByFilled;
        }
    }
}
