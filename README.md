
# **Игра Меморија** 

Windows Forms Project by: Nevena Stojanova and Kristina Petrusevska 

## 1.Опис на апликацијата 

 Темата на проектот кој го изработивме е апликација за играта  **Меморија** - игра со картички, во која сите карти се поклопени и две картички се отклопуваат во текот на секој чекор. Целта на играта е да се отклопуваат парови на појавување на картички.
 
 Играта покрај едноставниот дизајн, има три нивоа на играње со соодветен тајмер за секое ниво,како и инструкции за играње.

## 2.Упатство за користење

На почетниот прозорец при започнување на играта имаме можност одбереме на колку картички да играме, да ги видиме инструкциите за играта и да ја започнеме играта.


![image](https://cloud.githubusercontent.com/assets/28963796/26524262/bbd61496-432d-11e7-9049-05aa92c776cb.png)


### 2.1 Нивоа на играта-големина на блокот 

Најпрво се одбира големината на блокот ,каде што имаме три можности:

* 2X2
* 4X4
* 6X6

кои соодветствуваат на блокови составени од 4,16 или 36 картички.

### 2.2 Инструкции (Instructions)

Оваа функционалност служи за објаснување на играта и нејзините правила. После читањето на инструкциите имаме опција за исклучување на истите (OK).

### 2.3 Започни нова игра (Start)

Со оваа функционалност ја започнуваме играта со ниво кое претходно сме го избрале .
### 2.4 Нова игра (New Game )

Со оваа опција започнуваме нова игра на исто ниво а ја прекинуваме веќе започнатата .

### 2.5 Мени (Menu)

Со оваа опција ја прекинуваме започнатата игра и се враќаме во стартното мени. 

### 2.6 Правила

Правилата се едноставни:

* Картичките остануваат на видливата страна само ако во ист чекор сме отвориле две исти
* Картичките не остануваат на видливата страна ако во ист чекор не сме отвориле две исти
* Играчот има право на неограничен број на чекори се додека се во склоп на времето на дадено ниво
* Со отварање на сите картички во склоп на времето, играчот победува
* Со останати неотворени картички после истекувањето на времето, играчот губи.

## 3. Претставување на проблемот

### 3.1 Податочни структури

За играта се направени 4 форми од кои едната е почетна форма, а другите три се за трите нивоа од играта.

StartForm e почетната форма што ни се отвара со вклучување на играта :

```c#
namespace MatchingGame
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lChoices = new System.Windows.Forms.Label();
            this.cbChoices = new System.Windows.Forms.ComboBox();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
           
           .
           .
           .
           .
    }
}

```

#### 3.1.1 Start button

Со кликање на Start копчето,се отвара форма во зависност од изборот на нивото:

```c#
 private void btnStart_Click(object sender, EventArgs e)
        {
            
            if(cbChoices.Text == "4 X 4")
            {
                MG4x4 mg4x4 = new MG4x4();
                this.Hide();
                mg4x4.Show();
            }
            else if (cbChoices.Text == "2 X 2")
            {
                MG2x2 mg2x2 = new MG2x2();
                this.Hide();
                mg2x2.Show();
            }
            else
            {
                MG6x6 mg6x6 = new MG6x6();
                this.Hide();
                mg6x6.Show();
            }

        }

```
### 3.2 Алгоритми

За да биде целосна играта на судоку имплементиравме различни алгоритми за генерирање и валидирање на успешно решение.


