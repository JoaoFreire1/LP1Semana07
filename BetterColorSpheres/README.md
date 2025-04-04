classDiagram
        Color <|-- Sphere

        class Color {
          +Byte red
          +Byte green
          +Byte blue
          +Byte alpha
          +GetColor()
          +GetGray()
        }

        class Sphere {
          +Color color
          -float radius
          -int thrown
          +Pop()
          +Throw()
          +GetRadius()
          +GetTimesThrown()
          +GetColor()
        }
