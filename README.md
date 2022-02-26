# Dynamic Search

It's a demo.

like: tranform `(a > 10 and b > 10) or c < 100` to linq and as Queryable<T>

like: tranform `c in [1, 2, 3, 4]`

like: tranform `c` and c is boolean

Use `{}` to package tokens like `(a > 10 and b > 10) or c < 100` format as:
`{(}a > 10 {and} b > 10 {)} {or} c < 100`.

if yours query_contents had `{}`, please use other formats like:

`c {like} {{name:'Jack'}}` and it will skip yours query_contents.

op tokens:

`={= is like}, in, and, or, (, )`

use dynamic linq to build.
