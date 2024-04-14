using Godot;
using Godot.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class RabbitRanger : Rabbit
{
	// [ExportGroup("Attributes")]
	// [Export] public int _attack_damage = 5;
	// [Export] public float _attack_interval = 0.5f;
	// [Export] public Area2D _attack_range;
	private float attack_waittime = 0;
	// [Export(PropertyHint.Enum, "North,East,West,South")] public String _direction = "East";
	// // [Export] public bool _test_change_direction = false;
	// [Export] float _projectile_speed = 0.25f;
	// [Export] string _bullet_path;
	// private PackedScene _bullet;


	private bool _isAttacking = false;
	private bool _isReadyToAttack = true;
	private List<Cow> _enemy_list = new List<Cow>();
	private List<Cow> _current_attacking_enemy = new List<Cow>();
	private Cow _current_target;

	public RabbitRanger(){
		// attack_damage = _attack_damage;
		// attack_interval = _attack_interval;
		// attack_range = _attack_range;
		// direction = _direction;
		// projectile_speed = _projectile_speed;
		// bullet_path = _bullet_path;
	}


	// // Called when the node enters the scene tree for the first time.
	// public override void _Ready()
	// {
	// 	bullet = GD.Load<PackedScene>(bullet_path);
	// }

	// // Called every frame. 'delta' is the elapsed time since the previous frame.
	// public override void _Process(double delta)
	// {
	// 	if (enemy_list.Count > 0)
	// 	{

	// 		if (isReadyToAttack)
	// 		{
	// 			Logger.Instance.Print($"Going to attack: {enemy_list.Count}");
	// 			_attack();
	// 			attack_waittime = 0;
	// 			isReadyToAttack = false;
	// 		}

	// 	}

	// 	attack_waittime = timer(delta, attack_waittime);
	// 	if (attack_waittime > attack_interval)
	// 	{
	// 		isReadyToAttack = true;
	// 	}

	// 	if (_test_change_direction)
	// 	{
	// 		_updateDirection(direction);
	// 		_test_change_direction = false;
	// 	}
	// }

	// private void _on_attack_area_area_entered(Area2D area)
	// {

	// 	if (area.IsInGroup("Enemy"))
	// 	{
	// 		var enemy = area.GetParent();

	// 		if (enemy is Cow cow)
	// 		{
	// 			if (!enemy_list.Contains(enemy)) {
	// 				cow.isAlive();
	// 				enemy_list.Add(cow);
	// 				current_attacking_enemy.Add(cow);
	// 			}
				
	// 		}

	// 		Logger.Instance.Print("Enemy enter attack range");
	// 	}
	// 	Logger.Instance.Print($"enemy list: {enemy_list.Count}");
	// }

	// private void _on_attack_area_area_exited(Area2D area)
	// {

	// 	if (area.IsInGroup("Enemy"))
	// 	{
	// 		var enemy = area.GetParent();

	// 		if (enemy is Cow cow)
	// 		{
	// 			cow.isAlive();
	// 			enemy_list.Remove(cow);
	// 			current_attacking_enemy.Remove(cow);
	// 		}

	// 		Logger.Instance.Print("Enemy exit attack range");
	// 	}
	// 	Logger.Instance.Print($"enemy list: {enemy_list.Count}");
	// }

	// private void fireBulletV2(){	
	// 	Tween tween = GetTree().CreateTween();
	// 	var temp_bullet = bullet.Instantiate<Node2D>();
	// 	GetNode("../../ProjectileLayers").AddChild(temp_bullet);
	// 	temp_bullet.GlobalPosition = this.GlobalPosition;

	// 	current_target = this.current_attacking_enemy[0];
	// 	temp_bullet.LookAt(current_target.GlobalPosition);

	// 	tween.TweenProperty(
	// 		temp_bullet, 
	// 		"global_position", 
	// 		current_target.GlobalPosition, 
	// 		// 1f);
	// 		projectile_speed);
	// 	tween.Play();

	// 	// callback.Call(target);
	// 	tween.TweenCallback(Callable.From(temp_bullet.QueueFree));
	// 	tween.TweenCallback(Callable.From(this.dealDamage));
	// 	tween.TweenCallback(Callable.From(tween.Kill));
	// }

	// private void dealDamage() {
	// 	current_target.BeAttackBy(attack_damage);
	// 	current_target = null;
	// }


	// private void _attack()
	// {
	// 	Logger.Instance.Print($"Attacking...");


	// 	if (this.enemy_list[0].isAlive())
	// 	{
	// 		Logger.Instance.Print($"Attack enemy at position {this.enemy_list[0].GlobalPosition}");
	// 		fireBulletV2();
	// 		// this.enemy_list[0].BeAttackBy(attack_damage);
	// 	}
	// 	else
	// 	{
	// 		Logger.Instance.Print($"Enemy isAlive: {this.enemy_list[0].isAlive()}");
	// 		Logger.Instance.Print($"Remove from list");
	// 		this.enemy_list.RemoveAt(0);
	// 	}

	// 	// _customSignalSingleton.EmitSignal(nameof(CustomSignalSingleton.getDamgeByPlayerEventHandler), this.attack_damage);
	// }

	// private float timer(double delta, float a)
	// {
	// 	return a += 1 * (float)delta;
	// }

	// private void _updateDirection(String direction)
	// {

	// 	switch (direction)
	// 	{
	// 		case "North":
	// 			this.RotationDegrees = -90;
	// 			break;
	// 		case "East":
	// 			this.RotationDegrees = 0;
	// 			break;
	// 		case "South":
	// 			this.RotationDegrees = 90;
	// 			break;
	// 		case "West":
	// 			this.RotationDegrees = 180;
	// 			break;

	// 	}

	// }
}
