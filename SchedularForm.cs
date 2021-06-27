using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Project
{
    public partial class SchedularForm : Form

    {

        public LinkedList<Workout> allWorkouts = new LinkedList<Workout>();//Where all workouts are stored

        public LinkedList<Workout> dayOneSchedule = new LinkedList<Workout>();//lists that display to day one, two, and three respectively
        public LinkedList<Workout> dayTwoSchedule = new LinkedList<Workout>();
        public LinkedList<Workout> dayThreeSchedule = new LinkedList<Workout>();

        public LinkedList<Workout> arrangedWorkout = new LinkedList<Workout>();//Workouts arranged based on user arguments will be stored here

        public bool createSchedButtonclicked;//used to see if Workout elements have populated the list boxes
        public int numCBChecked = 0;//used to see if at least one target group is selected

        [System.ComponentModel.Bindable(true)]//needed to use these lines for selecteditem property
        [System.ComponentModel.Browsable(false)]
        public object SelectedItem { get; set; }

        public LinkedListNode<Workout> selectedWorkoutNode;
        int selectedDay = 0;
        public SchedularForm()
        {
            InitializeComponent();
            InitializeWorkout();
        }
        private void InitializeWorkout()//all wokrout objects will be created here
        {
            Workout dumbellCurls = new Workout("Dumbell Curls", "mass", "arms", 5, 25);
            allWorkouts.AddLast(dumbellCurls);

            Workout cgpushUps = new Workout("Close Grip Push Ups", "strength", "arms", 5, 20);
            allWorkouts.AddLast(cgpushUps);

            Workout squats = new Workout("Squats", "strength", "legs", 6, 15);
            allWorkouts.AddLast(squats);

            Workout wallSits = new Workout("Wall Sits", "mass", "legs", 5, 30);
            allWorkouts.AddLast(wallSits);

            Workout benchPress = new Workout("Bench Press", "mass", "chest", 5, 20);
            allWorkouts.AddLast(benchPress);

            Workout wgpushUps = new Workout("Wide Group Push Ups", "strength", "chest", 5, 20);
            allWorkouts.AddLast(wgpushUps);

            Workout bendrow = new Workout("Bend Over Row", "mass", "back", 3, 15);
            allWorkouts.AddLast(bendrow);

            Workout rowmachine = new Workout("Rowing Machine", "strength", "back", 4, 20);
            allWorkouts.AddLast(rowmachine);

            Workout crunches = new Workout("Crunches", "mass", "abs", 5, 25);
            allWorkouts.AddLast(crunches);

            Workout rustwists = new Workout("Russian Twists", "strength", "abs", 5, 25);
            allWorkouts.AddLast(rustwists);


        }
        public class Workout // main object in program Workout
        {
            public string name;
            public string goal;
            public string musclegroup;
            public int sets;
            public int reps;

            public Workout()
            {
                
            }
            public Workout(string name, string goal, string musclegroup, int sets, int reps)
            {
                this.name = name;
                this.goal = goal;
                this.musclegroup = musclegroup;
                this.sets = sets;
                this.reps = reps;


            }
             public LinkedList<Workout> buildMuscleList(LinkedList<Workout> selectedWorkout, LinkedList<Workout> allWorkouts, string msgrp, string goal) //makes a list of workouts through user inputs
            {
                
                foreach(Workout workout in allWorkouts)
                {
                    if (workout.musclegroup == msgrp && workout.goal == goal)
                    {
                        selectedWorkout.AddLast(workout);
                    }
                }
                return selectedWorkout;


            }
            
        }
        


        public class Schedule//handles all scheduling inputs from the user and based on workouts.
        {
            public LinkedList<Workout> d1;
            public LinkedList<Workout> d2;
            public LinkedList<Workout> d3;
            public void buildschedule(LinkedList<Workout> d1, LinkedList<Workout> d2, LinkedList<Workout> d3, LinkedList<Workout> selWorkout)
            {
                this.d1 = d2;
                this.d2 = d2;
                this.d3 = d3;
                LinkedListNode<Workout> node = selWorkout.First;

                int count = 0;
                d1.Clear();
                d2.Clear();
                d3.Clear();

                while (node!= null)//handles moving of the workout
                {
                   
                    if (count == 0)
                    {
                       
                        selWorkout.RemoveFirst();
                        d1.AddLast(node);
                        node = selWorkout.First;

                        count++;
                    }
                    else  if(count == 1)
                    {
                        selWorkout.RemoveFirst();
                        d2.AddLast(node);
                        node = selWorkout.First;
                        count++;
                    }
                    else if(count == 2)
                    {
                        selWorkout.RemoveFirst();
                        d3.AddLast(node);
                        node = selWorkout.First;
                        count = 0;
                    }
                }

            }


            
        }

      

        private void Createschedule_Click_1(object sender, EventArgs e)//Creates the schedule event
        {
            Workout aW = new Workout();
            Schedule allScheduledWorkouts = new Schedule();
            string goal = "";

            if (legscb.Checked || armscb.Checked || chestcb.Checked || backcb.Checked || abscb.Checked)//Checks at least one CB is checked 
            {
                numCBChecked++;
            }
            else
            {
                MessageBox.Show("Please Select At Least One Target Muscle Group");
            }
   
            if (numCBChecked == 1)
            {
                createSchedButtonclicked = true;
            }
            if (massRB.Checked)
            {
                goal = "mass";
            }
            else if (strengthRB.Checked)
            {
                goal = "strength";
            }
            else
            {
                MessageBox.Show("Please Select a Goal");
            }

            

            if (legscb.Checked)//creates new schedule based on given parameters
            {
                arrangedWorkout = aW.buildMuscleList(arrangedWorkout, allWorkouts, "legs", goal);                
            }
            if (armscb.Checked)
            {
                arrangedWorkout = aW.buildMuscleList(arrangedWorkout, allWorkouts, "arms", goal);
            }
            if (chestcb.Checked)
            {
                arrangedWorkout = aW.buildMuscleList(arrangedWorkout, allWorkouts, "chest", goal);
            }
            if (backcb.Checked)
            {
                arrangedWorkout = aW.buildMuscleList(arrangedWorkout, allWorkouts, "back", goal);
            }
            if (abscb.Checked)
            {
                arrangedWorkout = aW.buildMuscleList(arrangedWorkout, allWorkouts, "abs", goal);
            }

            allScheduledWorkouts.buildschedule(dayOneSchedule, dayTwoSchedule, dayThreeSchedule, arrangedWorkout);

            refreshAllDayList();

        }
        public void identifySelectedWorkoutNode(LinkedList<Workout> dayLS, int selIndex)
        {
            LinkedListNode<Workout> aNode = dayLS.First;
            for (int i = 0; i < selIndex; i++)//goes to selected index and sets workout node to it
            {
                aNode = aNode.Next;
            }
            selectedWorkoutNode = aNode;

        }

        private void Dayone_SelectedIndexChanged_1(object sender, EventArgs e)//Makes sure only one item from all three list boxes can be selected at once
        {
            
            if (dayone.SelectedIndex >= 0)
            {
                selectedDay = 1;
                daytwo.SelectedIndex = -1;
                daythree.SelectedIndex = -1;
                identifySelectedWorkoutNode(dayOneSchedule, dayone.SelectedIndex);

            }

        }

        private void Daytwo_SelectedIndexChanged(object sender, EventArgs e)//Makes sure only one item from all three list boxes can be selected at once
        {
            if (daytwo.SelectedIndex >= 0)
            {
                selectedDay = 2;
                dayone.SelectedIndex = -1;
                daythree.SelectedIndex = -1;
                identifySelectedWorkoutNode(dayTwoSchedule, daytwo.SelectedIndex);
            }

        }
        private void Daythree_SelectedIndexChanged(object sender, EventArgs e)//Makes sure only one item from all three list boxes can be selected at once
        {
            if(daythree.SelectedIndex >= 0)
            {
                selectedDay = 3;
                daytwo.SelectedIndex = -1;
                dayone.SelectedIndex = -1;
                identifySelectedWorkoutNode(dayThreeSchedule, daythree.SelectedIndex);
            }
            
        }
        public void refreshAllDayList()//clears out all the workouts from the ListBox
        {
            dayone.Items.Clear();
            daytwo.Items.Clear();
            daythree.Items.Clear();
            foreach (Workout workout in dayOneSchedule)
            {
                dayone.Items.Add(workout.name + workout.sets + "x" + workout.reps);
            }

            foreach (Workout workout in dayTwoSchedule)
            {
                daytwo.Items.Add(workout.name + workout.sets + "x" + workout.reps);
            }

            foreach (Workout workout in dayThreeSchedule)
            {
                daythree.Items.Add(workout.name + workout.sets + "x" + workout.reps);
            }
        }

        private void Dayonemove_Click(object sender, EventArgs e)//moves selected Workout in one of the three selections 
        {
            if (createSchedButtonclicked && (daytwo.SelectedIndex >= 0 || daythree.SelectedIndex >= 0))
            {
                if (selectedDay == 1)
                {
                    MessageBox.Show("Select a different day to move workout to.");
                }
                else
                {

                    if (selectedDay == 2)
                    {
                        dayTwoSchedule.Remove(selectedWorkoutNode);
                    }
                    else if (selectedDay == 3)
                    {
                        dayThreeSchedule.Remove(selectedWorkoutNode);
                    }
                    dayOneSchedule.AddLast(selectedWorkoutNode);
                    refreshAllDayList();
                }
            }
            else
            {
                MessageBox.Show("Please populate the Workouts through clicking the Create Schedule Button and/or select one to move");
            }
        }
        private void Daytwomove_Click(object sender, EventArgs e)
        {
            if (createSchedButtonclicked && (dayone.SelectedIndex >= 0 || daythree.SelectedIndex >= 0))
            {
                if (selectedDay == 2)
                {
                    MessageBox.Show("Select a different day to move workout to.");
                }
                else
                {
                    if (selectedDay == 1)
                    {
                        dayOneSchedule.Remove(selectedWorkoutNode);
                    }
                    else if (selectedDay == 3)
                    {
                        dayThreeSchedule.Remove(selectedWorkoutNode);
                    }
                    dayTwoSchedule.AddLast(selectedWorkoutNode);
                    refreshAllDayList();

                }
            }
            else
            {
                MessageBox.Show("Please populate the Workouts through clicking the Create Schedule Button and/or select one to move");
            }

        }


        private void Daythreemove_Click(object sender, EventArgs e)
        {
            if (createSchedButtonclicked && (dayone.SelectedIndex >= 0 || daytwo.SelectedIndex >= 0))
            {
                if (selectedDay == 3)
                {
                    MessageBox.Show("Select a different day to move workout to.");
                }
                else
                {
                    if (selectedDay == 1)
                    {
                        dayOneSchedule.Remove(selectedWorkoutNode);
                    }
                    else if (selectedDay == 2)
                    {
                        dayTwoSchedule.Remove(selectedWorkoutNode);
                    }
                    dayThreeSchedule.AddLast(selectedWorkoutNode);
                    refreshAllDayList();
                }
            }
            else
            {
                MessageBox.Show("Please populate the Workouts through clicking the Create Schedule Button and/or select one to move");
            }
        }

        private void Refreshschedule_Click(object sender, EventArgs e)//Resets all variables to initial values and clears the list box 
        {
            dayOneSchedule.Clear();
            dayTwoSchedule.Clear();
            dayThreeSchedule.Clear();
            refreshAllDayList();
            createSchedButtonclicked = false;
            numCBChecked = 0;
        }


    }
        
}
