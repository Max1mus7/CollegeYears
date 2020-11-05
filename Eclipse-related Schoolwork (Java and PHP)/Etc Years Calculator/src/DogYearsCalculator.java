import java.util.Scanner;

public class DogYearsCalculator {
	
	public static String Calculate(int secondsIn)
	{
		
		if(secondsIn <=0)
		{
			return null;
		}
		else 
		{
			int yearsOut = secondsIn/31536000*7;
			secondsIn -= yearsOut*31536000/7;
			int daysOut = secondsIn/86400*7;
			secondsIn -= daysOut*86400/7;
			while(daysOut >= 365)
			{
				yearsOut += 1;
				daysOut -= 365;
			}
			int hoursOut = secondsIn/3600*7;
			secondsIn -= hoursOut*3600/7;
			while(hoursOut >= 24)
			{
				daysOut += 1;
				hoursOut -= 24;
			}
			int minutesOut = secondsIn/60*7;
			secondsIn -= minutesOut*60/7;
			while(minutesOut >= 60) 
			{
				hoursOut += 1;
				minutesOut -= 60;
			}
			int secondsOut = secondsIn*7;
			while(secondsOut >= 60)
			{
				minutesOut += 1;
				secondsOut -= 60;
			}
			return "It would take " + yearsOut + " years, " + daysOut + " days, " + hoursOut + " hours, " + minutesOut + " minutes, and "
					+ secondsOut + " seconds for your event to occur.";
		}
	}

	public static void main(String[] args) 
	{
		Scanner input = new Scanner(System.in);
		int numYears;
		int numDays;
		int numHours;
		int numMinutes;
		int numSeconds;
		int totalSeconds;
		
		System.out.println("This program determines the length of time something takes to occur in dog years, "
				+ "given a time in human years.\n\nPlease input the amount of years something takes(or zero for less than a year):");
		numYears = input.nextInt();
		System.out.println("Please input the amount of time remaining in days(or zero for less than a day):");
		numDays = input.nextInt();
		System.out.println("Please input the amount of time remaining in hours(or zero for less than a hour):");
		numHours = input.nextInt();
		System.out.println("Please input the amount of time remaining in minutes(or zero for less than a minute):");
		numMinutes = input.nextInt();
		System.out.println("Please input the amount of time remaining in seconds:");
		numSeconds = input.nextInt();
		totalSeconds = numYears*31536000 + numDays*86400 + numHours*3600 + numMinutes*60 + numSeconds;
		System.out.println(Calculate(totalSeconds));
	}

}
