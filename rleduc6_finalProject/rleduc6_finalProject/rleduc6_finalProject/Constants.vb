Public Class Constants
    'Final number for 100% completion
    'Collection Badges
    Private Const CATALOGUE_COMPLETE As Integer = 3000
    Private Const FISH_COMPLETE As Integer = 72
    Private Const INSECT_COMPLETE As Integer = 72
    Private Const SEAFOOD_COMPLETE As Integer = 30

    'Numbers needed for next level of badge completion
    'Collection Badges
    Private Const FISH_BADGE_BRONZE As Integer = 36
    Private Const FISH_BADGE_SILVER As Integer = 58
    Private Const FISH_BADGE_GOLD As Integer = 72

    Private Const CATALOGUE_BADGE_BRONZE As Integer = 600
    Private Const CATALOGUE_BADGE_SILVER As Integer = 1500
    Private Const CATALOGUE_BADGE_GOLD As Integer = 2400

    Private Const INSECT_BADGE_BRONZE As Integer = 36
    Private Const INSECT_BADGE_SILVER As Integer = 58
    Private Const INSECT_BADGE_GOLD As Integer = 72

    Private Const SEAFOOD_BADGE_BRONZE As Integer = 15
    Private Const SEAFOOD_BADGE_SILVER As Integer = 24
    Private Const SEAFOOD_BADGE_GOLD As Integer = 30

    'Catalogue Properties
    Public ReadOnly Property GetCatalogueComplete As Integer
        Get
            Return CATALOGUE_COMPLETE
        End Get
    End Property

    Public ReadOnly Property GetCatalogueBronze As Integer
        Get
            Return CATALOGUE_BADGE_BRONZE
        End Get
    End Property

    Public ReadOnly Property GetCatalogueSilver As Integer
        Get
            Return CATALOGUE_BADGE_SILVER
        End Get
    End Property

    Public ReadOnly Property GetCatalogueGold As Integer
        Get
            Return CATALOGUE_BADGE_GOLD
        End Get
    End Property

    'Fish Properties
    Public ReadOnly Property GetFishComplete As Integer
        Get
            Return FISH_COMPLETE
        End Get
    End Property

    Public ReadOnly Property GetFishBronze As Integer
        Get
            Return FISH_BADGE_BRONZE
        End Get
    End Property

    Public ReadOnly Property GetFishSilver As Integer
        Get
            Return FISH_BADGE_SILVER
        End Get
    End Property

    Public ReadOnly Property GetFishGold As Integer
        Get
            Return FISH_BADGE_GOLD
        End Get
    End Property

    'Insect Properties
    Public ReadOnly Property GetInsectComplete As Integer
        Get
            Return INSECT_COMPLETE
        End Get
    End Property

    Public ReadOnly Property GetInsectBronze As Integer
        Get
            Return INSECT_BADGE_BRONZE
        End Get
    End Property

    Public ReadOnly Property GetInsectSilver As Integer
        Get
            Return INSECT_BADGE_SILVER
        End Get
    End Property

    Public ReadOnly Property GetInsectGold As Integer
        Get
            Return INSECT_BADGE_GOLD
        End Get
    End Property

    'Seafood Properties
    Public ReadOnly Property GetSeafoodComplete As Integer
        Get
            Return SEAFOOD_COMPLETE
        End Get
    End Property

    Public ReadOnly Property GetSeafoodBronze As Integer
        Get
            Return SEAFOOD_BADGE_BRONZE
        End Get
    End Property

    Public ReadOnly Property GetSeafoodSilver As Integer
        Get
            Return SEAFOOD_BADGE_SILVER
        End Get
    End Property

    Public ReadOnly Property GetSeafoodGold As Integer
        Get
            Return SEAFOOD_BADGE_GOLD
        End Get
    End Property
End Class
