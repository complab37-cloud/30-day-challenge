double centerX = 0, centerY = 0;

double firstCircle = 2, secondCircle = 4, thirdCircle = 6, fourthCircle = 8;

int pointsInner = 10, pointsMiddle = 8, pointsOuter = 5, pointsFar = 2;

double hitX = 3, hitY = 1;

const double EPSILON = 1e-9;

double dx = hitX - centerX;
double dy = hitY - centerY;
double distance = Math.Sqrt(dx * dx + dy * dy);

double earnedPoints;


if (distance < firstCircle - EPSILON)
    earnedPoints = pointsInner;
else if (Math.Abs(distance - firstCircle) <= EPSILON)
    earnedPoints = pointsInner / 2.0;

else if (distance < secondCircle - EPSILON)
    earnedPoints = pointsMiddle;
else if (Math.Abs(distance - secondCircle) <= EPSILON)
    earnedPoints = pointsMiddle / 2.0;

else if (distance < thirdCircle - EPSILON)
    earnedPoints = pointsOuter;
else if (Math.Abs(distance - thirdCircle) <= EPSILON)
    earnedPoints = pointsOuter / 2.0;

else if (distance < fourthCircle - EPSILON)
    earnedPoints = pointsFar;
else if (Math.Abs(distance - fourthCircle) <= EPSILON)
    earnedPoints = pointsFar / 2.0;

else
    earnedPoints = 0;


Console.WriteLine($"Earned points: {earnedPoints}");

Console.ReadLine();