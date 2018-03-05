Option Strict On
Option Explicit On

Public Class Mayor
    'Mayor information variables
    Private mMayorName As String
    Private mTownName As String
    Private mMayorInfo As String
    Private mID As Integer = -1

    'Skill Badge variables
    'Collection
    Private mCatalogueBadgeNum As Integer
    Private mFishBadgeNum As Integer
    Private mInsectBadgeNum As Integer
    Private mSeafoodBadgeNum As Integer

    'Constructor
    Public Sub New()
        mMayorName = String.Empty
        mTownName = String.Empty
        mMayorInfo = String.Empty
        mCatalogueBadgeNum = 0
        mFishBadgeNum = 0
        mInsectBadgeNum = 0
        mSeafoodBadgeNum = 0
    End Sub

    'Calculate mayor badge percentage completion
    Public ReadOnly Property CalcPercentCompletetion(ByVal badgeNum As Integer, ByVal badgeCompleteNum As Integer) As Double
        Get
            Dim percentComplete As Double
            percentComplete = CDbl(badgeNum) / CDbl(badgeCompleteNum)
            Return percentComplete
        End Get
    End Property

    'Properties to Calculate Mayor Badge Level
    Public ReadOnly Property GetNextFishLevel(ByVal progress As Double) As Double
        Get
            Const B_PERCENT = 0.5
            Const S_PERCENT = 0.8
            Const G_PERCENT = 1.0
            Dim nextLevel As Double

            If progress < B_PERCENT Then
                nextLevel = B_PERCENT
            ElseIf progress < S_PERCENT Then
                nextLevel = S_PERCENT
            Else
                nextLevel = G_PERCENT
            End If
            Return nextLevel
        End Get
    End Property

    Public ReadOnly Property GetNextCatalogueLevel(ByVal progress As Double) As Double
        Get
            Const B_PERCENT = 0.2
            Const S_PERCENT = 0.5
            Const G_PERCENT = 0.8
            Dim nextLevel As Double

            If progress < B_PERCENT Then
                nextLevel = B_PERCENT
            ElseIf progress < S_PERCENT Then
                nextLevel = S_PERCENT
            Else
                nextLevel = G_PERCENT
            End If
            Return nextLevel
        End Get
    End Property

    Public ReadOnly Property GetNextInsectLevel(ByVal progress As Double) As Double
        Get
            Const B_PERCENT = 0.5
            Const S_PERCENT = 0.8
            Const G_PERCENT = 1.0
            Dim nextLevel As Double

            If progress < B_PERCENT Then
                nextLevel = B_PERCENT
            ElseIf progress < S_PERCENT Then
                nextLevel = S_PERCENT
            Else
                nextLevel = G_PERCENT
            End If
            Return nextLevel
        End Get
    End Property

    Public ReadOnly Property GetNextSeafoodLevel(ByVal progress As Double) As Double
        Get
            Const B_PERCENT = 0.5
            Const S_PERCENT = 0.8
            Const G_PERCENT = 1.0
            Dim nextLevel As Double

            If progress < B_PERCENT Then
                nextLevel = B_PERCENT
            ElseIf progress < S_PERCENT Then
                nextLevel = S_PERCENT
            Else
                nextLevel = G_PERCENT
            End If
            Return nextLevel
        End Get
    End Property

    'Getters and setters
    Public Property MayorInfo As String
        Get
            mMayorInfo = mMayorName & ", of " & mTownName
            Return mMayorInfo
        End Get
        Set(ByVal value As String)
            mMayorInfo = value
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return mID
        End Get
        Set(ByVal value As Integer)
            mID = value
        End Set
    End Property

    Public Property MayorName As String
        Get
            Return mMayorName
        End Get
        Set(value As String)
            mMayorName = value
        End Set
    End Property

    Public Property TownName As String
        Get
            Return mTownName
        End Get
        Set(value As String)
            mTownName = value
        End Set
    End Property

    Public Property CatalogueBadgeNum As Integer
        Get
            Return mCatalogueBadgeNum
        End Get
        Set(value As Integer)
            mCatalogueBadgeNum = value
        End Set
    End Property

    Public Property FishBadgeNum As Integer
        Get
            Return mFishBadgeNum
        End Get
        Set(value As Integer)
            mFishBadgeNum = value
        End Set
    End Property

    Public Property InsectBadgeNum As Integer
        Get
            Return mInsectBadgeNum
        End Get
        Set(value As Integer)
            mInsectBadgeNum = value
        End Set
    End Property

    Public Property SeafoodBadgeNum As Integer
        Get
            Return mSeafoodBadgeNum
        End Get
        Set(value As Integer)
            mSeafoodBadgeNum = value
        End Set
    End Property

End Class
