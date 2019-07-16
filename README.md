# Knight's Tour Problem

A demonstration of the classic Knight's Tour Problem.

A knight's tour is a sequence of moves of a knight on a chessboard such that the knight visits every square only once. If the knight ends on a square that is one knight's move from the beginning square (so that it could tour the board again immediately, following the same path), the tour is closed, otherwise it is open.

This application implements two strategies: Non-Intelligent (Random) and Warnsdorff's rule

### Non-Intelligent (Random)

A straight forward strategy where a knight is moved to a random square (that it has not yet visited) within it's range until it can move no more.

### Warnsdorff's rule

Warnsdorff's rule is a heuristic for finding a single knight's tour. The knight is moved so that it always proceeds to the square from which the knight will have the fewest onward moves. When calculating the number of onward moves for each candidate square, we do not count moves that revisit any square already visited. It is possible to have two or more choices for which the number of onward moves is equal; in such a case, the choice is chosen at random between the possible choices.
