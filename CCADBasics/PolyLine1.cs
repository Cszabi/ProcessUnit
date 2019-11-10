using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows.Media.Media3D;

namespace CCADBasics
{
    public class PolyLine : IEnumerable<Point3D>, IEqualityComparer<PolyLine>, IEquatable<PolyLine>
    {
        public string Linetype { get; set; }
        public string Layer { get; set; }
        public LinkedList<Point3D> Points { get => _points; set => _points = value; }
        public bool IsClosed { get; set; }

        private LinkedList<Point3D> _points;


        public PolyLine()
        {
            _points = new LinkedList<Point3D>();
        }
        public PolyLine(params Point3D[] inputpoints)
        {

            foreach (var item in inputpoints)
            {
                _points.AddLast(item);
            }

        }
        public void Add(Point3D point) => _points.AddLast(point);

        public void AddRange(IEnumerable<Point3D> inputpoints)
        {
            foreach (var item in inputpoints)
            {
                _points.AddLast(item);
            }
        }

        public void Remove(Point3D point) => _points.Remove(point);

        
        //public void Reverse() => _points.Reverse();
        public bool Contains(Point3D pointtocheck) => _points.Contains(pointtocheck);

        public int Count() => _points.Count;
        public IEnumerator<Point3D> GetEnumerator() => _points.GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator() => _points.GetEnumerator();

        public bool Equals([AllowNull] PolyLine x, [AllowNull] PolyLine y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode([DisallowNull] PolyLine obj)
        {
            throw new NotImplementedException();
        }

        public bool Equals([AllowNull] PolyLine other)
        {
            var currentNodeofThis = _points.First;
            var currentNodeofOther = other._points.First;
            
            if (other == null) return false;
            
            while (currentNodeofThis != null)
            {
                if (currentNodeofThis != currentNodeofOther) return false;        
                currentNodeofThis = currentNodeofThis.Next;
                currentNodeofOther = currentNodeofOther.Next;
            }
            return true;
        }
    }
}
