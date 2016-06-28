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
        private Dictionary<string, IBrush> brushes;

        public CanvasPresenter(ICanvasView view, ICanvas model)
        {
            InitializeView(view);
            this.model = model;
            InitializeBrushes();
        }

        public CanvasPresenter(ICanvasView view, ICanvas model, Bitmap bmp)
            : this(view, model)
        {
            InitializeModel(model, bmp);
        }

        private void InitializeBrushes()
        {
            brushes = new Dictionary<string, IBrush>();
            brushes.Add("line", new Brushes.Line());
            brushes.Add("rubber", new Brushes.Rubber());
            brushes.Add("rectangle", new Brushes.Rectangle());
            brushes.Add("elipsis", new Brushes.Elipsis());
            brushes.Add("spray", new Brushes.Spray());
            brushes.Add("image", new Brushes.Image());
            brushes.Add("polygon", new Brushes.Polygon());
            brushes.Add("gradient", new Brushes.Gradient());

        }

        private void InitializeModel(ICanvas model, Bitmap bmp)
        {
            this.model = model;
            if (bmp != null)
            {
                model.RefreshTemporaryObjects(new Brushes.Image(bmp), new List<Point>());
                model.CommitTemporaryObjects();
                view.NextObjects = model.Objects;
            }
        }

        private void InitializeView(ICanvasView view)
        {
            this.view = view;
            view.BrushSelected += OnBrushSelected;
            view.PathUpdated += OnPathUpdated;
            view.SelectedColor += OnColorSelected;
            view.SelectedSize += OnSizeSelected;
            view.OptionSelected += OnOptionSelected;
            view.FilledChanged += OnFilledChanged;
            view.FileSelected += OnFileSelected;
            view.Commit += OnCommit;
        }

        private void OnFileSelected(object sender, string e)
        {
            currentBrush.Filename = e;
        }

        private void OnFilledChanged(object sender, bool e)
        {
            currentBrush.Filled = e;
        }

        private void OnOptionSelected(object sender, string e)
        {
            currentOption = e;
        }

        private void OnCommit(object sender, EventArgs e)
        {
            InitializeBrushes();
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
            view.BrushNeedsFile = currentBrush.NeedsFile;
            view.BrushOptions = currentBrush.Options;
        }
    }
}
